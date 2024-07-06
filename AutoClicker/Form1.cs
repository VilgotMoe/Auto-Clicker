using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private bool isRunning = false;
        private CancellationTokenSource cancellationTokenSource;

        // Constants for global hotkey
        private const int HOTKEY_ID = 1;
        private const int MOD_NOREPEAT = 0x4000;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1()
        {
            InitializeComponent();
            cmbClickType.Items.AddRange(new string[] { "Left", "Right" });
            cmbClickAction.Items.AddRange(new string[] { "Single", "Double" });
            cmbClickType.SelectedIndex = 0;
            cmbClickAction.SelectedIndex = 0;

            // Default settings
            rbRepeatUntilStopped.Checked = true;
            numericUpDownRepeatCount.Enabled = false;

            rbRepeat.CheckedChanged += new EventHandler(RbRepeat_CheckedChanged);
            rbRepeatUntilStopped.CheckedChanged += new EventHandler(RbRepeatUntilStopped_CheckedChanged);
        }

        private int GetInterval()
        {
            int hours = int.TryParse(txtHours.Text, out hours) ? hours : 0;
            int minutes = int.TryParse(txtMinutes.Text, out minutes) ? minutes : 0;
            int seconds = int.TryParse(txtSeconds.Text, out seconds) ? seconds : 0;
            int milliseconds = int.TryParse(txtMilliseconds.Text, out milliseconds) ? milliseconds : 0;

            return (hours * 3600 + minutes * 60 + seconds) * 1000 + milliseconds;
        }

        private async void PerformClick(CancellationToken cancellationToken)
        {
            uint down, up;
            string clickType = string.Empty;
            string clickAction = string.Empty;

            this.Invoke((MethodInvoker)delegate {
                clickType = cmbClickType.SelectedItem.ToString();
                clickAction = cmbClickAction.SelectedItem.ToString();
            });

            if (clickType == "Left")
            {
                down = MOUSEEVENTF_LEFTDOWN;
                up = MOUSEEVENTF_LEFTUP;
            }
            else
            {
                down = MOUSEEVENTF_RIGHTDOWN;
                up = MOUSEEVENTF_RIGHTUP;
            }

            int interval = GetInterval();
            int repeatCount = 0;
            int maxRepeats = (int)numericUpDownRepeatCount.Value;

            try
            {
                while (!cancellationToken.IsCancellationRequested && (rbRepeatUntilStopped.Checked || repeatCount < maxRepeats))
                {
                    mouse_event(down, 0, 0, 0, UIntPtr.Zero);
                    mouse_event(up, 0, 0, 0, UIntPtr.Zero);

                    if (clickAction == "Double")
                    {
                        await Task.Delay(100, cancellationToken); // Short delay between double clicks
                        mouse_event(down, 0, 0, 0, UIntPtr.Zero);
                        mouse_event(up, 0, 0, 0, UIntPtr.Zero);
                    }

                    await Task.Delay(interval, cancellationToken);
                    repeatCount++;
                }
            }
            catch (TaskCanceledException)
            {
                // Task was canceled, handle any cleanup if needed
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate {
                    isRunning = false;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                });
            }
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                cancellationTokenSource = new CancellationTokenSource();
                Task.Run(() => PerformClick(cancellationTokenSource.Token));
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (isRunning)
            {
                cancellationTokenSource.Cancel();
                isRunning = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                if (isRunning)
                {
                    btnStop.PerformClick();
                }
                else
                {
                    btnStart.PerformClick();
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, Keys.F6);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }

        private void RbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownRepeatCount.Enabled = rbRepeat.Checked;
        }

        private void RbRepeatUntilStopped_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownRepeatCount.Enabled = !rbRepeatUntilStopped.Checked;
        }
    }
}

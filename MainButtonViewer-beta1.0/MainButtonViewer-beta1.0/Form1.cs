using System.Diagnostics;
using Gma.System.MouseKeyHook;

namespace MainButtonViewer_beta1._0
{
    public partial class Form1 : Form
    {
        public bool wpressed = false;
        public bool apressed = false;
        public bool spressed = false;
        public bool dpressed = false;
        public bool lmbpressed = false;
        public bool rmbpressed = false;
        public bool spacepressed = false;
        public bool explained = true;
        public bool debugMode = true;
        public int distance = 5;
        public int cpsl;
        public int cpsr;
        public int red = 99;
        public int green;
        public int blue = 99;
        public string red2;
        public string green2;
        public string blue2;
        public int reda = 99;
        public int greena;
        public int bluea = 99;
        public string red2a;
        public string green2a;
        public string blue2a;
        public int reds = 99;
        public int greens;
        public int blues = 99;
        public string red2s;
        public string green2s;
        public string blue2s;
        public int redd = 99;
        public int greend;
        public int blued = 99;
        public string red2d;
        public string green2d;
        public string blue2d;
        public int redlmb = 99;
        public int greenlmb;
        public int bluelmb = 99;
        public string red2lmb;
        public string green2lmb;
        public string blue2lmb;
        public int redrmb = 99;
        public int greenrmb;
        public int bluermb = 99;
        public string red2rmb;
        public string green2rmb;
        public string blue2rmb;
        public int redspace = 99;
        public int greenspace;
        public int bluespace = 99;
        public string red2space;
        public string green2space;
        public string blue2space;
        public int rgb;
        private IKeyboardMouseEvents m_GlobalHook;
        public int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(debugMode == false)
            {
                labelDebug.Visible = false;
            }
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            m_GlobalHook.KeyUp += onKeyUp;
            m_GlobalHook.KeyDown += onKeyDown;
            m_GlobalHook.MouseDownExt += MouseDown;
            m_GlobalHook.MouseUpExt += MouseUp;
            m_GlobalHook.MouseClick += MouseDownUp;
            labelW.Height = 50;
            labelW.Width = 50;
            labelA.Height = 50;
            labelA.Width = 50;
            labelS.Height = 50;
            labelS.Width = 50;
            labelD.Height = 50;
            labelD.Width = 50;
            labelMBL.Height = 50;
            labelMBL.Width = 75 + distance / 2;
            labelMBR.Height = 50;
            labelMBR.Width = 75 + distance / 2;
            labelcpsl.Height = 12;
            labelcpsl.Width = labelMBL.Width;
            labelcpsr.Height = 12;
            labelcpsr.Width = labelMBR.Width;
            panelSpace.Height = 30;
            panelSpace.Width = labelMBL.Width + labelMBR.Width + distance;
            panelSpaceLine.Height = 2;
            panelSpaceLine.Width = panelSpace.Width / 4 * 2;
            labelW.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            labelA.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            labelS.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            labelD.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            labelMBL.Font = new Font("Segoe UI", 19, FontStyle.Bold);
            labelMBR.Font = new Font("Segoe UI", 19, FontStyle.Bold);
            labelcpsl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            labelW.Text = "W";
            labelA.Text = "A";
            labelS.Text = "S";
            labelD.Text = "D";
            labelMBL.Text = "LMB";
            labelMBR.Text = "RMB";
            this.Opacity = .80;
            labelD.Location = new Point(this.Width - labelD.Width - distance, labelD.Height + distance * 2);
            labelW.Location = new Point(labelD.Location.X - labelD.Width - distance, distance);
            labelS.Location = new Point(labelW.Location.X, labelW.Location.Y + labelS.Height + distance);
            labelA.Location = new Point(labelS.Location.X - labelA.Width - distance, labelS.Location.Y);
            labelMBL.Location = new Point(labelA.Location.X, labelA.Location.Y + labelMBL.Height + distance);
            labelMBR.Location = new Point(labelMBL.Location.X + labelMBR.Width + distance, labelMBL.Location.Y);
            labelcpsl.Location = new Point(labelMBL.Location.X, labelMBL.Location.Y + labelMBL.Height - labelcpsl.Height - 6);
            labelcpsr.Location = new Point(labelMBR.Location.X, labelMBR.Location.Y + labelMBR.Height - labelcpsr.Height - 6);
            panelSpace.Location = new Point(labelMBL.Location.X, labelMBL.Location.Y + labelMBL.Height + distance);
            panelSpaceLine.Location = new Point(panelSpace.Location.X + panelSpace.Width / 4, panelSpace.Location.Y + panelSpace.Height / 2);
            labelDebug.Location = new Point(this.Width / 2, this.Height / 2);
            labelW.TextAlign = ContentAlignment.MiddleCenter;
            labelA.TextAlign = ContentAlignment.MiddleCenter;
            labelS.TextAlign = ContentAlignment.MiddleCenter;
            labelD.TextAlign = ContentAlignment.MiddleCenter;
            labelMBL.TextAlign = ContentAlignment.TopCenter;
            labelMBR.TextAlign = ContentAlignment.TopCenter;
            labelcpsl.TextAlign = ContentAlignment.MiddleCenter;
            labelcpsr.TextAlign = ContentAlignment.MiddleCenter;
            labelW.ForeColor = ColorTranslator.FromHtml("#990099");
            labelW.ForeColor = ColorTranslator.FromHtml("#990099");
            labelA.ForeColor = ColorTranslator.FromHtml("#990099");
            labelS.ForeColor = ColorTranslator.FromHtml("#990099");
            labelD.ForeColor = ColorTranslator.FromHtml("#990099");
            labelMBR.ForeColor = ColorTranslator.FromHtml("#990099");
            labelMBL.ForeColor = ColorTranslator.FromHtml("#990099");
            labelcpsl.ForeColor = ColorTranslator.FromHtml("#990099");
            labelcpsr.ForeColor = ColorTranslator.FromHtml("#990099");
            panelSpaceLine.BackColor = ColorTranslator.FromHtml("#990099");
            calculatingrgbvoid();
            translatingrgbvoid();
            getProcessesRunning();
        }

        public async void getProcessesRunning()
        {
            await Task.Delay(5000);
            while (true)
            {
                //Console.WriteLine(p.ProcessName);
                Process[] processes = Process.GetProcesses();
                comboBoxProcess.Items.Clear();
                foreach (Process process in processes)
                {
                    if (process.ProcessName.ToString() != "svchost" && process.ProcessName != "Discord" && process.ProcessName.ToString() != "chrome" && process.ProcessName.ToString().Length < 11)
                    {
                        comboBoxProcess.Items.Add(process.ProcessName);
                    }
                }
                await Task.Delay(5000);
            }
        }

        public async void calculatingrgbvoid()
        {
            while (true)
            {
                await Task.Delay(50);
                if (blue != 0 && wpressed == true)
                {
                    blue--;
                }

                if (blue != 99 && wpressed == false)
                {
                    blue++;
                }

                if (bluea != 0 && apressed == true)
                {
                    bluea--;
                }

                if (bluea != 99 && apressed == false)
                {
                    bluea++;
                }

                if (blues != 0 && spressed == true)
                {
                    blues--;
                }

                if (blues != 99 && spressed == false)
                {
                    blues++;
                }

                if (blued != 0 && dpressed == true)
                {
                    blued--;
                }

                if (blued != 99 && dpressed == false)
                {
                    blued++;
                }

                if (bluelmb != 0 && lmbpressed == true)
                {
                    bluelmb--;
                }

                if (bluelmb != 99 && lmbpressed == false)
                {
                    bluelmb++;
                }

                if (bluermb != 0 && rmbpressed == true)
                {
                    bluermb--;
                }

                if (bluermb != 99 && rmbpressed == false)
                {
                    bluermb++;
                }

                if (bluespace != 0 && spacepressed == true)
                {
                    bluespace--;
                }

                if (bluespace != 99 && spacepressed == false)
                {
                    bluespace++;
                }
            }
        }

        public async void translatingrgbvoid()
        {
            while (true)
            {
                await Task.Delay(100);
                red2 = red.ToString();
                green2 = green.ToString();
                blue2 = blue.ToString();
                red2a = reda.ToString();
                green2a = greena.ToString();
                blue2a = bluea.ToString();
                red2s = reds.ToString();
                green2s = greens.ToString();
                blue2s = blues.ToString();
                red2d = redd.ToString();
                green2d = greend.ToString();
                blue2d = blued.ToString();
                red2lmb = redlmb.ToString();
                green2lmb = greenlmb.ToString();
                blue2lmb = bluelmb.ToString();
                red2rmb = redrmb.ToString();
                green2rmb = greenrmb.ToString();
                blue2rmb = bluermb.ToString();
                red2space = redspace.ToString();
                green2space = greenspace.ToString();
                blue2space = bluespace.ToString();

                if (red2.Length != 2)
                {
                    red2 = "0" + red2;
                }

                if (green2.Length != 2)
                {
                    green2 = "0" + green2;
                }

                if (blue2.Length != 2)
                {
                    blue2 = "0" + blue2;
                }

                if (red2a.Length != 2)
                {
                    red2a = "0" + red2a;
                }

                if (green2a.Length != 2)
                {
                    green2a = "0" + green2a;
                }

                if (blue2a.Length != 2)
                {
                    blue2a = "0" + blue2a;
                }

                if (red2s.Length != 2)
                {
                    red2s = "0" + red2s;
                }

                if (green2s.Length != 2)
                {
                    green2s = "0" + green2s;
                }

                if (blue2s.Length != 2)
                {
                    blue2s = "0" + blue2s;
                }

                if (red2d.Length != 2)
                {
                    red2d = "0" + red2d;
                }

                if (green2d.Length != 2)
                {
                    green2d = "0" + green2d;
                }

                if (blue2d.Length != 2)
                {
                    blue2d = "0" + blue2d;
                }

                if (red2lmb.Length != 2)
                {
                    red2lmb = "0" + red2lmb;
                }

                if (green2lmb.Length != 2)
                {
                    green2lmb = "0" + green2lmb;
                }

                if (blue2lmb.Length != 2)
                {
                    blue2lmb = "0" + blue2lmb;
                }

                if (red2rmb.Length != 2)
                {
                    red2rmb = "0" + red2rmb;
                }

                if (green2rmb.Length != 2)
                {
                    green2rmb = "0" + green2rmb;
                }

                if (blue2rmb.Length != 2)
                {
                    blue2rmb = "0" + blue2rmb;
                }

                if (red2space.Length != 2)
                {
                    red2space = "0" + red2space;
                }

                if (green2space.Length != 2)
                {
                    green2space = "0" + green2space;
                }

                if (blue2space.Length != 2)
                {
                    blue2space = "0" + blue2space;
                }

                //labelDebug.Text = "hex = #" + red2 + green2 + blue2;
            }
        }

        private async void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine(e.KeyChar); //"KeyPress: \t{0}",
        }

        public void Unhook()
        {
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            m_GlobalHook.KeyUp -= onKeyUp;
            m_GlobalHook.KeyDown -= onKeyDown;
            m_GlobalHook.MouseClick -= MouseDownUp;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (explained == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    labelW.BackColor = Color.Gray;
                    wpressed = false;
                }

                if (e.KeyCode == Keys.A)
                {
                    labelA.BackColor = Color.Gray;
                    apressed = false;
                }

                if (e.KeyCode == Keys.S)
                {
                    labelS.BackColor = Color.Gray;
                    spressed = false;
                }

                if (e.KeyCode == Keys.D)
                {
                    labelD.BackColor = Color.Gray;
                    dpressed = false;
                }

                if (e.KeyCode == Keys.Space)
                {
                    panelSpace.BackColor = Color.Gray;
                    spacepressed = false;
                }
            }
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (explained == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    labelW.BackColor = Color.LightGray;
                    wpressed = true;
                }

                if (e.KeyCode == Keys.A)
                {
                    labelA.BackColor = Color.LightGray;
                    apressed = true;
                }

                if (e.KeyCode == Keys.S)
                {
                    labelS.BackColor = Color.LightGray;
                    spressed = true;
                }

                if (e.KeyCode == Keys.D)
                {
                    labelD.BackColor = Color.LightGray;
                    dpressed = true;
                }

                if(e.KeyCode == Keys.Space)
                {
                    panelSpace.BackColor = Color.LightGray;
                    spacepressed = true;
                }

            }
        }

        private void MouseDown(object sender, MouseEventExtArgs e)
        {
            if (explained == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    labelMBL.BackColor = Color.LightGray;
                    labelcpsl.BackColor = labelMBL.BackColor;
                    lmbpressed = true;
                }

                if (e.Button == MouseButtons.Right)
                {
                    labelMBR.BackColor = Color.LightGray;
                    labelcpsr.BackColor = labelMBR.BackColor;
                    rmbpressed = true;
                }
            }
        }

        private void MouseUp(object sender, MouseEventExtArgs e)
        {
            if (explained == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    labelMBL.BackColor = Color.Gray;
                    labelcpsl.BackColor = labelMBL.BackColor;
                    lmbpressed = false;
                }

                if (e.Button == MouseButtons.Right)
                {
                    labelMBR.BackColor = Color.Gray;
                    labelcpsr.BackColor = labelMBR.BackColor;
                    rmbpressed = false;
                }
            }
        }

        private void MouseDownUp(object sender, MouseEventArgs e)
        {
            if (explained == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    cpsl++;
                }

                if (e.Button == MouseButtons.Right)
                {
                    cpsr++;
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            labelW.ForeColor = ColorTranslator.FromHtml("#" + red2 + green2 + blue2);
            labelA.ForeColor = ColorTranslator.FromHtml("#" + red2a + green2a + blue2a);
            labelS.ForeColor = ColorTranslator.FromHtml("#" + red2s + green2s + blue2s);
            labelD.ForeColor = ColorTranslator.FromHtml("#" + red2d + green2d + blue2d);
            labelMBL.ForeColor = ColorTranslator.FromHtml("#" + red2lmb + green2lmb + blue2lmb);
            labelMBR.ForeColor = ColorTranslator.FromHtml("#" + red2rmb + green2rmb + blue2rmb);
            labelcpsl.ForeColor = ColorTranslator.FromHtml("#" + red2lmb + green2lmb + blue2lmb);
            labelcpsr.ForeColor = ColorTranslator.FromHtml("#" + red2rmb + green2rmb + blue2rmb);
            panelSpaceLine.BackColor = ColorTranslator.FromHtml("#" + red2space + green2space + blue2space);
            //labelW.ForeColor = ColorTranslator.FromHtml("#990099");
            if (Process.GetProcessesByName("chrome").Length > 0)
            {
                //this.Opacity = .0;
            }
            
            if(Process.GetProcessesByName("chrome").Length == 0)
            {
                this.Opacity = .80;
            }
        }

        private void timerCps_Tick(object sender, EventArgs e)
        {
            labelcpsl.Text = "CPS: " + cpsl.ToString();
            labelcpsr.Text = "CPS: " + cpsr.ToString();
            cpsl = 0;
            cpsr = 0;
        }

        private async void timerRGB_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer500_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
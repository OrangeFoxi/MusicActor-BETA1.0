using NAudio.CoreAudioApi;
using Gma.System.MouseKeyHook;



namespace MusicActorBeta1._0
{
    public partial class Form1 : Form
    {

        public float MasterValue;
        public int highestMasterValue;
        public int minMusicValue = 10;
        public bool musicPlaying = false;
        public bool openGUI = true;
        public bool extendedGUI = false;
        public int mousex;
        public int mousey;
        public bool extendedMoveMenu = false;
        public bool progressBarMoving = false;
        public int progressBarLocationY;
        public int progressBarLocationX;
        public bool labelMousePosMoving = false;
        public int labelMousePosY;
        public int labelMousePosX;
        public bool extendedColorMenu = false;
        public Color color = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonMoveMenu.ForeColor = color;
            buttonMoveProgressbar.ForeColor = Color.Magenta;
            buttonMoveMousePosLabel.ForeColor = Color.Magenta;
            buttonShowGUI.Visible = false; //nutton show gui ist hinter buttonextendgui!
            buttonChangeColors.Visible = false;
            buttonChangeColors.Text = "Colors";
            buttonShowGUI.Text = "close GUI";
            buttonExtendGUI.Text = "options";
            buttonMoveMenu.Text = "Move";
            buttonMoveMousePosLabel.Text = "MouseLab";
            buttonMoveProgressbar.Text = "MusicBar";
            progressBar1.Location = new Point(this.Width - progressBar1.Width - 130, progressBar1.Height + 50); // this.Width / 2 - progressBar1.Width / 2, this.Height / 2 - progressBar1.Height / 2
            comboBox1.Location = new Point(progressBar1.Location.X + 10, progressBar1.Location.Y - 30); // ich verwende - weil die y achse von oben nach unten zunimmt
            labelMasterValue.Location = new Point(comboBox1.Location.X - 100, comboBox1.Location.Y);
            labelHighestMasterValue.Location = new Point(comboBox1.Location.X + comboBox1.Width + 10, comboBox1.Location.Y);
            buttonShowGUI.Location = new Point(progressBar1.Location.X + progressBar1.Width + buttonShowGUI.Width / 2, progressBar1.Location.Y + progressBar1.Height / 2 - buttonShowGUI.Height / 2);
            buttonExtendGUI.Location = new Point(buttonShowGUI.Location.X, buttonShowGUI.Location.Y); // + buttonShowGUI.Height + buttonExtendGUI.Height / 2
            buttonMoveMenu.Location = new Point(buttonExtendGUI.Location.X, buttonExtendGUI.Location.Y + buttonExtendGUI.Height + buttonMoveMenu.Height / 2);
            labelMousePosition.Location = new Point(progressBar1.Location.X - labelMousePosition.Width - 40, progressBar1.Location.Y);
            buttonMoveProgressbar.Location = new Point(buttonMoveMenu.Location.X, buttonMoveMenu.Location.Y + buttonMoveProgressbar.Height + buttonMoveProgressbar.Height / 2);
            buttonMoveMousePosLabel.Location = new Point(buttonMoveProgressbar.Location.X, buttonMoveProgressbar.Location.Y + buttonMoveMousePosLabel.Height + buttonMoveMousePosLabel.Height / 2);
            buttonChangeColors.Location = new Point(buttonMoveMenu.Location.X, buttonMoveMenu.Location.Y + buttonChangeColors.Height + buttonChangeColors.Height / 2);
            textboxChangeButtonColor.Location = new Point(buttonChangeColors.Location.X + buttonChangeColors.Width - textboxChangeButtonColor.Width, buttonChangeColors.Location.Y + textboxChangeButtonColor.Height + textboxChangeButtonColor.Height / 2);
            comboBox1.Visible = true;
            buttonMoveMenu.Visible = false;
            buttonMoveProgressbar.Visible = false;
            buttonMoveMousePosLabel.Visible = false;
            textboxChangeButtonColor.Visible = false;
            ifMusicPlayingTimer.Stop();
            mainTimer.Start();
            updateTimer.Start();

            var combination1 = Combination.TriggeredBy(Keys.F3); //Wenn welcher Key gedrückt wurde
            var combination2 = Combination.TriggeredBy(Keys.H);
            
            Action callback = onpressF3; //welches Void abgerufen werden soll (platzhalter für das void)
            Action callback2 = onpressH;

            var assignment = new Dictionary<Combination, Action> //Tabellensystem
            {
                {combination1, callback},    //wenn neuer keyhook dann:
                                             //var combination2 = Combin.....
                                             //Action callback2 = neuer Void Name;
                                             //var assingnment = new Dictionary<Combination, Action>{ {combination1, callback}, {combination2, callback2} };
                {combination2, callback2}
            };

            Hook.GlobalEvents().OnCombination(assignment); //Ausleser des Tabellensystems
        }

        void onpressF3()
        {
            if (openGUI == false)
            {
                buttonShowGUI.Text = "close GUI";
                openGUI = true;
                comboBox1.Visible = true;
                progressBar1.Visible = true;
                labelHighestMasterValue.Visible = true;
                labelMasterValue.Visible = true;
                buttonExtendGUI.Visible = true;
                buttonMoveMenu.Visible = true;
                labelMousePosition.Visible = true;
            }
            else if (openGUI == true)
            {
                buttonShowGUI.Text = "open GUI";
                openGUI = false;
                comboBox1.Visible = false;
                progressBar1.Visible = false;
                labelHighestMasterValue.Visible = false;
                labelMasterValue.Visible = false;
                buttonExtendGUI.Visible = false;
                buttonMoveMenu.Visible = false;
                labelMousePosition.Visible = false;
            }
        }

        void onpressH()
        {
            progressBarMoving = false;
            labelMousePosMoving = false;
        }

        private async void mainTimer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                MasterValue = (int)(device.AudioMeterInformation.MasterPeakValue * 100);
                if (MasterValue > highestMasterValue)
                {
                    highestMasterValue = (int)MasterValue;
                }
            }

            if (comboBox1.SelectedItem != null && musicPlaying == true)
            {
                ifMusicPlayingTimer.Start();
            }

            if (musicPlaying == false) // || comboBox1.SelectedItem == null
            {
                ifMusicPlayingTimer.Stop();
                await Task.Delay(1000);
                if (musicPlaying == false)
                {
                    await Task.Delay(1000);
                    if (musicPlaying == false)
                    {
                        await Task.Delay(1000);
                        if (musicPlaying == false)
                        {
                            highestMasterValue = 0;
                            MasterValue = 0;
                            labelMasterValue.Text = "Volume: " + 0.ToString();
                            labelHighestMasterValue.Text = "Highest Volume: " + 0.ToString();
                        }
                    }
                }
            }

        }

        private async void updateTimer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (MasterValue > minMusicValue)
                {
                    await Task.Delay(1000);
                    if (MasterValue > minMusicValue)
                    {
                        await Task.Delay(1000);
                        if (MasterValue > minMusicValue)
                        {
                            await Task.Delay(1000);
                            if (MasterValue > minMusicValue)
                            {
                                musicPlaying = true;
                            }
                        }
                    }
                }
            }

            if (comboBox1.SelectedItem != null)
            {
                if (MasterValue < minMusicValue)
                {
                    await Task.Delay(1000);
                    if (MasterValue < minMusicValue)
                    {
                        await Task.Delay(1000);
                        if (MasterValue < minMusicValue)
                        {
                            await Task.Delay(1000);
                            if (MasterValue < minMusicValue)
                            {
                                musicPlaying = false;
                                progressBar1.Value = (int)0;
                            }
                        }
                    }
                }
            }

            labelMousePosition.Text = Cursor.Position.X + "; " + Cursor.Position.Y.ToString();
            mousex = Cursor.Position.X;
            mousey = Cursor.Position.Y;

            //porgressbarmoving:

            if(progressBarMoving == true)
            {
                progressBar1.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                progressBarLocationX = progressBar1.Location.X;
                progressBarLocationY = progressBar1.Location.Y;
            }
            
            if(progressBarMoving == false && progressBarLocationX != 0)
            {
                progressBar1.Location = new Point(progressBarLocationX, progressBarLocationY);
            }

            //labelmouseposmoving:

            if (labelMousePosMoving == true)
            {
                labelMousePosition.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                labelMousePosX = labelMousePosition.Location.X;
                labelMousePosY = labelMousePosition.Location.Y;
            }

            if (labelMousePosMoving == false && labelMousePosX != 0)
            {
                labelMousePosition.Location = new Point(labelMousePosX, labelMousePosY);
            }

        }

        private void buttonShowGUI_Click(object sender, EventArgs e)
        {
            if (openGUI == false)
            {
                buttonShowGUI.Text = "close GUI";
                openGUI = true;
                comboBox1.Visible = true;
                progressBar1.Visible = true;
                labelHighestMasterValue.Visible = true;
                labelMasterValue.Visible = true;
                buttonExtendGUI.Visible = true;
                buttonMoveMenu.Visible = true;
            }
            else if (openGUI == true)
            {
                buttonShowGUI.Text = "open GUI";
                openGUI = false;
                comboBox1.Visible = false;
                progressBar1.Visible = false;
                labelHighestMasterValue.Visible = false;
                labelMasterValue.Visible = false;
                buttonExtendGUI.Visible = false;
                buttonMoveMenu.Visible = false;
            }
        }



        private void ifMusicPlayingTimer_Tick(object sender, EventArgs e)
        {
            var samedevice = (MMDevice)comboBox1.SelectedItem;
            progressBar1.Value = (int)(samedevice.AudioMeterInformation.MasterPeakValue * 100);
            labelMasterValue.Text = "Volume: " + MasterValue.ToString();
            labelHighestMasterValue.Text = "Highest Volume: " + highestMasterValue.ToString();
        }

        private void buttonExtendGUI_Click(object sender, EventArgs e)
        {
            //alle buttons eintagen!
            if(extendedGUI == false)
            {
                extendedGUI = true;
                buttonExtendGUI.Text = "options";
                buttonChangeColors.Location = new Point(buttonMoveMenu.Location.X, buttonMoveMenu.Location.Y + buttonChangeColors.Height + buttonChangeColors.Height / 2);
                buttonMoveMenu.Visible = false;
                buttonChangeColors.Visible = false;
                buttonMoveProgressbar.Visible = false;
                buttonMoveMousePosLabel.Visible = false;
                textboxChangeButtonColor.Visible = false;
            }
            else if(extendedGUI == true)
            {
                extendedGUI = false;
                buttonExtendGUI.Text = "close";
                buttonMoveMenu.Visible = true;
                buttonChangeColors.Visible = true;
            }
        }

        private void buttonMoveMenu_Click(object sender, EventArgs e)
        {
            if(extendedMoveMenu == false)
            {
                extendedMoveMenu = true;
                buttonMoveProgressbar.Visible = true;
                buttonMoveMousePosLabel.Visible = true;
                buttonChangeColors.Location = new Point(buttonMoveMousePosLabel.Location.X, buttonMoveMousePosLabel.Location.Y + buttonChangeColors.Height + buttonChangeColors.Height / 2);
            }
            else if(extendedMoveMenu == true)
            {
                extendedMoveMenu = false;
                buttonMoveProgressbar.Visible = false;
                buttonMoveMousePosLabel.Visible = false;
                buttonChangeColors.Location = new Point(buttonMoveMenu.Location.X, buttonMoveMenu.Location.Y + buttonChangeColors.Height + buttonChangeColors.Height / 2);
            }
        }

        private void buttonMoveProgressbar_Click(object sender, EventArgs e)
        {
            if(progressBarMoving == false)
            {
                progressBarMoving = true;
            }
        }

        private void buttonMoveMousePosLabel_Click(object sender, EventArgs e)
        {
            if (labelMousePosMoving == false)
            {
                labelMousePosMoving = true;
            }
        }

        private void buttonChangeColors_Click(object sender, EventArgs e)
        {
            if(extendedColorMenu == false)
            {
                extendedColorMenu = true;
                textboxChangeButtonColor.Visible = false;
            }
            else if(extendedColorMenu == true)
            {
                extendedColorMenu = false;
                textboxChangeButtonColor.Visible = true;
            }
        }
    }
}
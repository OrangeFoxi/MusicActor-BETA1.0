namespace MusicActorBeta1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelHighestMasterValue = new System.Windows.Forms.Label();
            this.labelMasterValue = new System.Windows.Forms.Label();
            this.ifMusicPlayingTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonShowGUI = new System.Windows.Forms.Button();
            this.buttonExtendGUI = new System.Windows.Forms.Button();
            this.buttonMoveMenu = new System.Windows.Forms.Button();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.buttonMoveProgressbar = new System.Windows.Forms.Button();
            this.buttonMoveMousePosLabel = new System.Windows.Forms.Button();
            this.buttonChangeColors = new System.Windows.Forms.Button();
            this.textboxChangeButtonColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(379, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 20);
            this.progressBar1.TabIndex = 1;
            // 
            // labelHighestMasterValue
            // 
            this.labelHighestMasterValue.AutoSize = true;
            this.labelHighestMasterValue.BackColor = System.Drawing.Color.Black;
            this.labelHighestMasterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelHighestMasterValue.Location = new System.Drawing.Point(308, 63);
            this.labelHighestMasterValue.Name = "labelHighestMasterValue";
            this.labelHighestMasterValue.Size = new System.Drawing.Size(55, 15);
            this.labelHighestMasterValue.TabIndex = 2;
            this.labelHighestMasterValue.Text = "pwbFOXI";
            // 
            // labelMasterValue
            // 
            this.labelMasterValue.AutoSize = true;
            this.labelMasterValue.BackColor = System.Drawing.Color.Black;
            this.labelMasterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMasterValue.Location = new System.Drawing.Point(274, 117);
            this.labelMasterValue.Name = "labelMasterValue";
            this.labelMasterValue.Size = new System.Drawing.Size(55, 15);
            this.labelMasterValue.TabIndex = 3;
            this.labelMasterValue.Text = "pwbFOXI";
            // 
            // ifMusicPlayingTimer
            // 
            this.ifMusicPlayingTimer.Tick += new System.EventHandler(this.ifMusicPlayingTimer_Tick);
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // buttonShowGUI
            // 
            this.buttonShowGUI.BackColor = System.Drawing.Color.Black;
            this.buttonShowGUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonShowGUI.Location = new System.Drawing.Point(500, 268);
            this.buttonShowGUI.Name = "buttonShowGUI";
            this.buttonShowGUI.Size = new System.Drawing.Size(75, 23);
            this.buttonShowGUI.TabIndex = 5;
            this.buttonShowGUI.Text = "pwbFOXI";
            this.buttonShowGUI.UseVisualStyleBackColor = false;
            this.buttonShowGUI.Click += new System.EventHandler(this.buttonShowGUI_Click);
            // 
            // buttonExtendGUI
            // 
            this.buttonExtendGUI.BackColor = System.Drawing.Color.Black;
            this.buttonExtendGUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExtendGUI.Location = new System.Drawing.Point(390, 304);
            this.buttonExtendGUI.Name = "buttonExtendGUI";
            this.buttonExtendGUI.Size = new System.Drawing.Size(75, 23);
            this.buttonExtendGUI.TabIndex = 6;
            this.buttonExtendGUI.Text = "pwbFOXI";
            this.buttonExtendGUI.UseVisualStyleBackColor = false;
            this.buttonExtendGUI.Click += new System.EventHandler(this.buttonExtendGUI_Click);
            // 
            // buttonMoveMenu
            // 
            this.buttonMoveMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMoveMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMoveMenu.Location = new System.Drawing.Point(387, 230);
            this.buttonMoveMenu.Name = "buttonMoveMenu";
            this.buttonMoveMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveMenu.TabIndex = 7;
            this.buttonMoveMenu.Text = "pwbFOXI";
            this.buttonMoveMenu.UseVisualStyleBackColor = false;
            this.buttonMoveMenu.Click += new System.EventHandler(this.buttonMoveMenu_Click);
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.BackColor = System.Drawing.Color.Black;
            this.labelMousePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelMousePosition.Location = new System.Drawing.Point(208, 185);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(52, 15);
            this.labelMousePosition.TabIndex = 9;
            this.labelMousePosition.Text = "pwbFoxi";
            // 
            // buttonMoveProgressbar
            // 
            this.buttonMoveProgressbar.BackColor = System.Drawing.Color.Black;
            this.buttonMoveProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMoveProgressbar.Location = new System.Drawing.Point(527, 186);
            this.buttonMoveProgressbar.Name = "buttonMoveProgressbar";
            this.buttonMoveProgressbar.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveProgressbar.TabIndex = 10;
            this.buttonMoveProgressbar.Text = "pwbFoxi";
            this.buttonMoveProgressbar.UseVisualStyleBackColor = false;
            this.buttonMoveProgressbar.Click += new System.EventHandler(this.buttonMoveProgressbar_Click);
            // 
            // buttonMoveMousePosLabel
            // 
            this.buttonMoveMousePosLabel.BackColor = System.Drawing.Color.Black;
            this.buttonMoveMousePosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMoveMousePosLabel.Location = new System.Drawing.Point(270, 227);
            this.buttonMoveMousePosLabel.Name = "buttonMoveMousePosLabel";
            this.buttonMoveMousePosLabel.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveMousePosLabel.TabIndex = 11;
            this.buttonMoveMousePosLabel.Text = "pwbFoxi";
            this.buttonMoveMousePosLabel.UseVisualStyleBackColor = false;
            this.buttonMoveMousePosLabel.Click += new System.EventHandler(this.buttonMoveMousePosLabel_Click);
            // 
            // buttonChangeColors
            // 
            this.buttonChangeColors.BackColor = System.Drawing.Color.Black;
            this.buttonChangeColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChangeColors.Location = new System.Drawing.Point(309, 179);
            this.buttonChangeColors.Name = "buttonChangeColors";
            this.buttonChangeColors.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeColors.TabIndex = 12;
            this.buttonChangeColors.Text = "pwbFoxi";
            this.buttonChangeColors.UseVisualStyleBackColor = false;
            this.buttonChangeColors.Click += new System.EventHandler(this.buttonChangeColors_Click);
            // 
            // textboxChangeButtonColor
            // 
            this.textboxChangeButtonColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textboxChangeButtonColor.Location = new System.Drawing.Point(274, 297);
            this.textboxChangeButtonColor.Name = "textboxChangeButtonColor";
            this.textboxChangeButtonColor.Size = new System.Drawing.Size(100, 23);
            this.textboxChangeButtonColor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxChangeButtonColor);
            this.Controls.Add(this.buttonChangeColors);
            this.Controls.Add(this.buttonMoveMousePosLabel);
            this.Controls.Add(this.buttonMoveProgressbar);
            this.Controls.Add(this.labelMousePosition);
            this.Controls.Add(this.buttonMoveMenu);
            this.Controls.Add(this.buttonExtendGUI);
            this.Controls.Add(this.buttonShowGUI);
            this.Controls.Add(this.labelMasterValue);
            this.Controls.Add(this.labelHighestMasterValue);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.buttonShowGUI_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ProgressBar progressBar1;
        private Label labelHighestMasterValue;
        private Label labelMasterValue;
        private System.Windows.Forms.Timer ifMusicPlayingTimer;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer updateTimer;
        private Button buttonShowGUI;
        private Button buttonExtendGUI;
        private Button buttonMoveMenu;
        private Label labelMousePosition;
        private Button buttonMoveProgressbar;
        private Button buttonMoveMousePosLabel;
        private Button buttonChangeColors;
        private TextBox textboxChangeButtonColor;
    }
}
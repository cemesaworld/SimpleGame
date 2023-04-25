namespace SimpleGame_Cemesa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.Key = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tag = "GameTimer";
            this.GameTimer.Tick += new System.EventHandler(this.NameTimerEvent);
            // 
            // txt_score
            // 
            this.txt_score.AutoSize = true;
            this.txt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(577, 12);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(76, 20);
            this.txt_score.TabIndex = 29;
            this.txt_score.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleGame_Cemesa.Properties.Resources.background1;
            this.pictureBox1.Location = new System.Drawing.Point(386, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 119);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox24.Location = new System.Drawing.Point(1111, 151);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(34, 27);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 32;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "Coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox22.Location = new System.Drawing.Point(1071, 151);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(34, 27);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 31;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "Coin";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox23.Location = new System.Drawing.Point(1269, 60);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(34, 27);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 28;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "Coin";
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // Key
            // 
            this.Key.Image = global::SimpleGame_Cemesa.Properties.Resources.key;
            this.Key.Location = new System.Drawing.Point(1354, 12);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(71, 34);
            this.Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Key.TabIndex = 27;
            this.Key.TabStop = false;
            this.Key.Tag = "Key";
            this.Key.Click += new System.EventHandler(this.Key_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox21.Location = new System.Drawing.Point(903, 364);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(34, 27);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 26;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "Coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox20.Location = new System.Drawing.Point(1015, 399);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(34, 27);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 25;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "Coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox19.Location = new System.Drawing.Point(889, 397);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(34, 27);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 24;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "Coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox18.Location = new System.Drawing.Point(783, 397);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(34, 27);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 23;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "Coin";
            // 
            // Coin1
            // 
            this.Coin1.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.Coin1.Location = new System.Drawing.Point(1209, 60);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(34, 27);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 22;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "Coin";
            this.Coin1.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox16.Location = new System.Drawing.Point(1151, 151);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(34, 27);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 21;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "Coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox15.Location = new System.Drawing.Point(1015, 366);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(34, 27);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 20;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "Coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox14.Location = new System.Drawing.Point(1071, 399);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(34, 27);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "Coin";
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox13.Location = new System.Drawing.Point(835, 397);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(34, 27);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 18;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "Coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox12.Location = new System.Drawing.Point(933, 184);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(34, 27);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 17;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "Coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox11.Location = new System.Drawing.Point(783, 196);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(34, 27);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Coin";
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox10.Location = new System.Drawing.Point(639, 276);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "Coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox9.Location = new System.Drawing.Point(580, 276);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "Coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox8.Location = new System.Drawing.Point(393, 151);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Coin";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.pictureBox6.Location = new System.Drawing.Point(353, 151);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Coin";
            // 
            // Coin
            // 
            this.Coin.Image = global::SimpleGame_Cemesa.Properties.Resources.coin1;
            this.Coin.Location = new System.Drawing.Point(313, 151);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(34, 27);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 11;
            this.Coin.TabStop = false;
            this.Coin.Tag = "Coin";
            // 
            // Door
            // 
            this.Door.Image = global::SimpleGame_Cemesa.Properties.Resources.door_closed;
            this.Door.Location = new System.Drawing.Point(59, 12);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(60, 90);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Door.TabIndex = 10;
            this.Door.TabStop = false;
            this.Door.Tag = "Door";
            this.Door.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // Player
            // 
            this.Player.Image = global::SimpleGame_Cemesa.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(193, 151);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 9;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Platform
            // 
            this.Platform.BackgroundImage = global::SimpleGame_Cemesa.Properties.Resources.platform;
            this.Platform.Location = new System.Drawing.Point(1, 430);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(536, 50);
            this.Platform.TabIndex = 1;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            this.Platform.Click += new System.EventHandler(this.Platform_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Platform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameisClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox Key;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txt_score;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


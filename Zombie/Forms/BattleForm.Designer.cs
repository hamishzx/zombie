﻿namespace Zombie
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.repeaterBox = new System.Windows.Forms.PictureBox();
            this.threePeashooterBox = new System.Windows.Forms.PictureBox();
            this.GoldDisplay = new System.Windows.Forms.Label();
            this.EcoUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.GoldTwinkleTimer = new System.Windows.Forms.Timer(this.components);
            this.GoldTwinkleOffTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeaterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePeashooterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Zombie.Properties.Resources.Peashooter;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // repeaterBox
            // 
            this.repeaterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeaterBox.Image = global::Zombie.Properties.Resources.card_repeaterpea;
            resources.ApplyResources(this.repeaterBox, "repeaterBox");
            this.repeaterBox.Name = "repeaterBox";
            this.repeaterBox.TabStop = false;
            this.repeaterBox.Click += new System.EventHandler(this.repeaterBox_Click);
            // 
            // threePeashooterBox
            // 
            this.threePeashooterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threePeashooterBox.Image = global::Zombie.Properties.Resources.card_threepeashooter;
            resources.ApplyResources(this.threePeashooterBox, "threePeashooterBox");
            this.threePeashooterBox.Name = "threePeashooterBox";
            this.threePeashooterBox.TabStop = false;
            this.threePeashooterBox.Click += new System.EventHandler(this.threePeashooterBox_Click);
            // 
            // GoldDisplay
            // 
            resources.ApplyResources(this.GoldDisplay, "GoldDisplay");
            this.GoldDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.GoldDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoldDisplay.Name = "GoldDisplay";
            this.GoldDisplay.TextChanged += new System.EventHandler(this.GoldDisplay_TextChanged);
            // 
            // EcoUpdateTimer
            // 
            this.EcoUpdateTimer.Enabled = true;
            this.EcoUpdateTimer.Interval = 1000;
            this.EcoUpdateTimer.Tick += new System.EventHandler(this.EcoUpdateTimer_Tick);
            // 
            // GoldTwinkleTimer
            // 
            this.GoldTwinkleTimer.Tick += new System.EventHandler(this.GoldTwinkleTimer_Tick);
            // 
            // GoldTwinkleOffTimer
            // 
            this.GoldTwinkleOffTimer.Interval = 500;
            this.GoldTwinkleOffTimer.Tick += new System.EventHandler(this.GoldTwinkleOffTimer_Tick);
            // 
            // BattleForm
            // 
            this.BackgroundImage = global::Zombie.Properties.Resources.background1;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.GoldDisplay);
            this.Controls.Add(this.threePeashooterBox);
            this.Controls.Add(this.repeaterBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Name = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BattleForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BattleForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BattleForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeaterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePeashooterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer GoldTwinkleOffTimer;

        private System.Windows.Forms.Timer GoldTwinkleTimer;

        private System.Windows.Forms.Timer EcoUpdateTimer;

        private System.Windows.Forms.Label GoldDisplay;
        
        private System.Windows.Forms.PictureBox threePeashooterBox;

        private System.Windows.Forms.PictureBox repeaterBox;

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
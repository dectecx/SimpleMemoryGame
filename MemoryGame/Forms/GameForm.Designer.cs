﻿namespace MemoryGame.Forms
{
    partial class GameForm
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
            this.LastTimeLabel = new System.Windows.Forms.Label();
            this.GamingTimer = new System.Windows.Forms.Timer(this.components);
            this.MemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MaskTimer = new System.Windows.Forms.Timer(this.components);
            this.MatchTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.RestartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastTimeLabel
            // 
            this.LastTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LastTimeLabel.Location = new System.Drawing.Point(427, 20);
            this.LastTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastTimeLabel.Name = "LastTimeLabel";
            this.LastTimeLabel.Size = new System.Drawing.Size(184, 38);
            this.LastTimeLabel.TabIndex = 0;
            this.LastTimeLabel.Text = "秒數";
            this.LastTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GamingTimer
            // 
            this.GamingTimer.Interval = 1000;
            this.GamingTimer.Tick += new System.EventHandler(this.GamingTimer_Tick);
            // 
            // MemoryTimer
            // 
            this.MemoryTimer.Interval = 1000;
            this.MemoryTimer.Tick += new System.EventHandler(this.MemoryTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.LightPink;
            this.ScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.Location = new System.Drawing.Point(256, 18);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(135, 43);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "得分:00";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.StartBtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartBtn.Location = new System.Drawing.Point(23, 17);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(150, 48);
            this.StartBtn.TabIndex = 17;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MaskTimer
            // 
            this.MaskTimer.Interval = 600;
            this.MaskTimer.Tick += new System.EventHandler(this.MaskTimer_Tick);
            // 
            // MatchTimer
            // 
            this.MatchTimer.Interval = 600;
            this.MatchTimer.Tick += new System.EventHandler(this.MatchTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox2.Location = new System.Drawing.Point(150, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox3.Location = new System.Drawing.Point(300, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox4.Location = new System.Drawing.Point(450, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox5.Location = new System.Drawing.Point(0, 150);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox6.Location = new System.Drawing.Point(150, 150);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox7.Location = new System.Drawing.Point(300, 150);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 150);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox8.Location = new System.Drawing.Point(450, 150);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(150, 150);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox9.Location = new System.Drawing.Point(0, 300);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(150, 150);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox10.Location = new System.Drawing.Point(150, 300);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(150, 150);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox11.Location = new System.Drawing.Point(300, 300);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(150, 150);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox12.Location = new System.Drawing.Point(450, 300);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(150, 150);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox13.Location = new System.Drawing.Point(0, 450);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(150, 150);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox14.Location = new System.Drawing.Point(150, 450);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(150, 150);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox15.Location = new System.Drawing.Point(300, 450);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(150, 150);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::MemoryGame.Properties.Resources.卡牌背面;
            this.pictureBox16.Location = new System.Drawing.Point(450, 450);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(150, 150);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "";
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePanel.BackColor = System.Drawing.Color.LightSalmon;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamePanel.Controls.Add(this.pictureBox16);
            this.GamePanel.Controls.Add(this.pictureBox15);
            this.GamePanel.Controls.Add(this.pictureBox14);
            this.GamePanel.Controls.Add(this.pictureBox13);
            this.GamePanel.Controls.Add(this.pictureBox12);
            this.GamePanel.Controls.Add(this.pictureBox11);
            this.GamePanel.Controls.Add(this.pictureBox10);
            this.GamePanel.Controls.Add(this.pictureBox9);
            this.GamePanel.Controls.Add(this.pictureBox8);
            this.GamePanel.Controls.Add(this.pictureBox7);
            this.GamePanel.Controls.Add(this.pictureBox6);
            this.GamePanel.Controls.Add(this.pictureBox5);
            this.GamePanel.Controls.Add(this.pictureBox4);
            this.GamePanel.Controls.Add(this.pictureBox3);
            this.GamePanel.Controls.Add(this.pictureBox2);
            this.GamePanel.Controls.Add(this.pictureBox1);
            this.GamePanel.Location = new System.Drawing.Point(23, 75);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(600, 600);
            this.GamePanel.TabIndex = 3;
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.RestartBtn.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RestartBtn.Location = new System.Drawing.Point(25, 16);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(150, 48);
            this.RestartBtn.TabIndex = 18;
            this.RestartBtn.Text = "重新開始";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Visible = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 691);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.LastTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "翻牌遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastTimeLabel;
        private System.Windows.Forms.Timer GamingTimer;
        private System.Windows.Forms.Timer MemoryTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Timer MaskTimer;
        private System.Windows.Forms.Timer MatchTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button RestartBtn;
    }
}
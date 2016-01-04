﻿namespace SendKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btnPressLeft = new System.Windows.Forms.Button();
            this.btnPressRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHoldRight = new System.Windows.Forms.Button();
            this.btnHoldLeft = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(76, 20);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(142, 20);
            this.txtDelay.TabIndex = 0;
            this.txtDelay.Text = "2000";
            // 
            // btnPressLeft
            // 
            this.btnPressLeft.Location = new System.Drawing.Point(10, 46);
            this.btnPressLeft.Name = "btnPressLeft";
            this.btnPressLeft.Size = new System.Drawing.Size(90, 23);
            this.btnPressLeft.TabIndex = 1;
            this.btnPressLeft.Text = "Left";
            this.btnPressLeft.UseVisualStyleBackColor = true;
            this.btnPressLeft.Click += new System.EventHandler(this.btnPressLeft_Click);
            // 
            // btnPressRight
            // 
            this.btnPressRight.Location = new System.Drawing.Point(128, 46);
            this.btnPressRight.Name = "btnPressRight";
            this.btnPressRight.Size = new System.Drawing.Size(90, 23);
            this.btnPressRight.TabIndex = 2;
            this.btnPressRight.Text = "Right";
            this.btnPressRight.UseVisualStyleBackColor = true;
            this.btnPressRight.Click += new System.EventHandler(this.btnPressRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(131, 177);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 2000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 13);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDelay);
            this.groupBox1.Controls.Add(this.btnPressLeft);
            this.groupBox1.Controls.Add(this.btnPressRight);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Click ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Delay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHoldRight);
            this.groupBox2.Controls.Add(this.btnHoldLeft);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Button Hold ";
            // 
            // btnHoldRight
            // 
            this.btnHoldRight.Location = new System.Drawing.Point(128, 19);
            this.btnHoldRight.Name = "btnHoldRight";
            this.btnHoldRight.Size = new System.Drawing.Size(90, 23);
            this.btnHoldRight.TabIndex = 3;
            this.btnHoldRight.Text = "Right";
            this.btnHoldRight.UseVisualStyleBackColor = true;
            this.btnHoldRight.Click += new System.EventHandler(this.btnHoldRight_Click);
            // 
            // btnHoldLeft
            // 
            this.btnHoldLeft.Location = new System.Drawing.Point(10, 21);
            this.btnHoldLeft.Name = "btnHoldLeft";
            this.btnHoldLeft.Size = new System.Drawing.Size(90, 23);
            this.btnHoldLeft.TabIndex = 2;
            this.btnHoldLeft.Text = "Left";
            this.btnHoldLeft.UseVisualStyleBackColor = true;
            this.btnHoldLeft.Click += new System.EventHandler(this.btnHoldLeft_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "----------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "mikebald\'s Automator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Button btnPressLeft;
        private System.Windows.Forms.Button btnPressRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHoldRight;
        private System.Windows.Forms.Button btnHoldLeft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
    }
}


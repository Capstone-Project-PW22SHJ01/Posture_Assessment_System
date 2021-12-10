
namespace PASys
{
    partial class formNordic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNordic));
            this.neckCheck = new System.Windows.Forms.CheckBox();
            this.ubCheck = new System.Windows.Forms.CheckBox();
            this.shouCheck = new System.Windows.Forms.CheckBox();
            this.elbowCheck = new System.Windows.Forms.CheckBox();
            this.lbCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ageVal = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timerVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerVal)).BeginInit();
            this.SuspendLayout();
            // 
            // neckCheck
            // 
            this.neckCheck.AutoSize = true;
            this.neckCheck.BackColor = System.Drawing.Color.Transparent;
            this.neckCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.neckCheck.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.neckCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.neckCheck.Location = new System.Drawing.Point(365, 168);
            this.neckCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.neckCheck.Name = "neckCheck";
            this.neckCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.neckCheck.Size = new System.Drawing.Size(133, 32);
            this.neckCheck.TabIndex = 2;
            this.neckCheck.Text = "Neck Pain";
            this.neckCheck.UseVisualStyleBackColor = false;
            this.neckCheck.CheckedChanged += new System.EventHandler(this.neckCheck_CheckedChanged);
            // 
            // ubCheck
            // 
            this.ubCheck.AutoSize = true;
            this.ubCheck.BackColor = System.Drawing.Color.Transparent;
            this.ubCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ubCheck.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ubCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.ubCheck.Location = new System.Drawing.Point(259, 244);
            this.ubCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ubCheck.Name = "ubCheck";
            this.ubCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ubCheck.Size = new System.Drawing.Size(193, 32);
            this.ubCheck.TabIndex = 3;
            this.ubCheck.Text = "Upper Back Pain";
            this.ubCheck.UseVisualStyleBackColor = false;
            this.ubCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // shouCheck
            // 
            this.shouCheck.AutoSize = true;
            this.shouCheck.BackColor = System.Drawing.Color.Transparent;
            this.shouCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shouCheck.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shouCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.shouCheck.Location = new System.Drawing.Point(586, 186);
            this.shouCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shouCheck.Name = "shouCheck";
            this.shouCheck.Size = new System.Drawing.Size(179, 32);
            this.shouCheck.TabIndex = 4;
            this.shouCheck.Text = "Shoulders Pain";
            this.shouCheck.UseVisualStyleBackColor = false;
            // 
            // elbowCheck
            // 
            this.elbowCheck.AutoSize = true;
            this.elbowCheck.BackColor = System.Drawing.Color.Transparent;
            this.elbowCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.elbowCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.elbowCheck.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elbowCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.elbowCheck.Location = new System.Drawing.Point(603, 244);
            this.elbowCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elbowCheck.Name = "elbowCheck";
            this.elbowCheck.Size = new System.Drawing.Size(153, 32);
            this.elbowCheck.TabIndex = 5;
            this.elbowCheck.Text = "Elbows Pain";
            this.elbowCheck.UseVisualStyleBackColor = false;
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.BackColor = System.Drawing.Color.Transparent;
            this.lbCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbCheck.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.lbCheck.Location = new System.Drawing.Point(617, 285);
            this.lbCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(192, 32);
            this.lbCheck.TabIndex = 6;
            this.lbCheck.Text = "Lower Back Pain";
            this.lbCheck.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(45, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Age :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ageVal
            // 
            this.ageVal.BackColor = System.Drawing.Color.White;
            this.ageVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageVal.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.ageVal.Location = new System.Drawing.Point(259, 369);
            this.ageVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ageVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageVal.Name = "ageVal";
            this.ageVal.Size = new System.Drawing.Size(73, 30);
            this.ageVal.TabIndex = 10;
            this.ageVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(77)))), ((int)(((byte)(73)))));
            this.button1.Location = new System.Drawing.Point(66, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(12, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notification Timer :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerVal
            // 
            this.timerVal.BackColor = System.Drawing.Color.White;
            this.timerVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerVal.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.timerVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timerVal.Location = new System.Drawing.Point(259, 421);
            this.timerVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timerVal.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timerVal.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.timerVal.Name = "timerVal";
            this.timerVal.Size = new System.Drawing.Size(73, 30);
            this.timerVal.TabIndex = 13;
            this.timerVal.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(338, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Min(s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formNordic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shouCheck);
            this.Controls.Add(this.neckCheck);
            this.Controls.Add(this.ubCheck);
            this.Controls.Add(this.timerVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ageVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.elbowCheck);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formNordic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formNordic";
            ((System.ComponentModel.ISupportInitialize)(this.ageVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox neckCheck;
        private System.Windows.Forms.CheckBox ubCheck;
        private System.Windows.Forms.CheckBox shouCheck;
        private System.Windows.Forms.CheckBox elbowCheck;
        private System.Windows.Forms.CheckBox lbCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ageVal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timerVal;
        private System.Windows.Forms.Label label1;
    }
}
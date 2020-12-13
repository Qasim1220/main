namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AltLbl = new System.Windows.Forms.Label();
            this.AltBtn = new System.Windows.Forms.Button();
            this.DollarBtn4 = new System.Windows.Forms.RadioButton();
            this.EuroBtn4 = new System.Windows.Forms.RadioButton();
            this.PoundBtn4 = new System.Windows.Forms.RadioButton();
            this.DollarBtn3 = new System.Windows.Forms.RadioButton();
            this.PoundBtn3 = new System.Windows.Forms.RadioButton();
            this.EuroBtn3 = new System.Windows.Forms.RadioButton();
            this.Value3txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DollarBtn3);
            this.panel1.Controls.Add(this.PoundBtn3);
            this.panel1.Controls.Add(this.EuroBtn3);
            this.panel1.Location = new System.Drawing.Point(13, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 126);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DollarBtn4);
            this.panel2.Controls.Add(this.EuroBtn4);
            this.panel2.Controls.Add(this.PoundBtn4);
            this.panel2.Location = new System.Drawing.Point(187, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 127);
            this.panel2.TabIndex = 1;
            // 
            // AltLbl
            // 
            this.AltLbl.AutoSize = true;
            this.AltLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltLbl.Location = new System.Drawing.Point(8, 9);
            this.AltLbl.Name = "AltLbl";
            this.AltLbl.Size = new System.Drawing.Size(230, 29);
            this.AltLbl.TabIndex = 2;
            this.AltLbl.Text = "Alter Exchange Rate";
            // 
            // AltBtn
            // 
            this.AltBtn.Location = new System.Drawing.Point(12, 188);
            this.AltBtn.Name = "AltBtn";
            this.AltBtn.Size = new System.Drawing.Size(75, 23);
            this.AltBtn.TabIndex = 3;
            this.AltBtn.Text = "Alter";
            this.AltBtn.UseVisualStyleBackColor = true;
            this.AltBtn.Click += new System.EventHandler(this.AltBtn_Click);
            // 
            // DollarBtn4
            // 
            this.DollarBtn4.AutoSize = true;
            this.DollarBtn4.Location = new System.Drawing.Point(130, 58);
            this.DollarBtn4.Name = "DollarBtn4";
            this.DollarBtn4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DollarBtn4.Size = new System.Drawing.Size(78, 21);
            this.DollarBtn4.TabIndex = 15;
            this.DollarBtn4.Text = "Dollar $";
            this.DollarBtn4.UseVisualStyleBackColor = true;
            // 
            // EuroBtn4
            // 
            this.EuroBtn4.AutoSize = true;
            this.EuroBtn4.Location = new System.Drawing.Point(137, 4);
            this.EuroBtn4.Name = "EuroBtn4";
            this.EuroBtn4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EuroBtn4.Size = new System.Drawing.Size(71, 21);
            this.EuroBtn4.TabIndex = 13;
            this.EuroBtn4.TabStop = true;
            this.EuroBtn4.Text = "Euro €";
            this.EuroBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EuroBtn4.UseVisualStyleBackColor = true;
            // 
            // PoundBtn4
            // 
            this.PoundBtn4.AutoSize = true;
            this.PoundBtn4.Location = new System.Drawing.Point(76, 31);
            this.PoundBtn4.Name = "PoundBtn4";
            this.PoundBtn4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PoundBtn4.Size = new System.Drawing.Size(132, 21);
            this.PoundBtn4.TabIndex = 14;
            this.PoundBtn4.TabStop = true;
            this.PoundBtn4.Text = "Pound sterling £";
            this.PoundBtn4.UseVisualStyleBackColor = true;
            // 
            // DollarBtn3
            // 
            this.DollarBtn3.AutoSize = true;
            this.DollarBtn3.Location = new System.Drawing.Point(3, 57);
            this.DollarBtn3.Name = "DollarBtn3";
            this.DollarBtn3.Size = new System.Drawing.Size(78, 21);
            this.DollarBtn3.TabIndex = 5;
            this.DollarBtn3.Text = "Dollar $";
            this.DollarBtn3.UseVisualStyleBackColor = true;
            // 
            // PoundBtn3
            // 
            this.PoundBtn3.AutoSize = true;
            this.PoundBtn3.Location = new System.Drawing.Point(3, 30);
            this.PoundBtn3.Name = "PoundBtn3";
            this.PoundBtn3.Size = new System.Drawing.Size(132, 21);
            this.PoundBtn3.TabIndex = 4;
            this.PoundBtn3.Text = "Pound sterling £";
            this.PoundBtn3.UseVisualStyleBackColor = true;
            // 
            // EuroBtn3
            // 
            this.EuroBtn3.AutoSize = true;
            this.EuroBtn3.Location = new System.Drawing.Point(3, 3);
            this.EuroBtn3.Name = "EuroBtn3";
            this.EuroBtn3.Size = new System.Drawing.Size(71, 21);
            this.EuroBtn3.TabIndex = 3;
            this.EuroBtn3.Text = "Euro €";
            this.EuroBtn3.UseVisualStyleBackColor = true;
            // 
            // Value3txt
            // 
            this.Value3txt.Location = new System.Drawing.Point(298, 188);
            this.Value3txt.Name = "Value3txt";
            this.Value3txt.Size = new System.Drawing.Size(104, 22);
            this.Value3txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exchange Rate:";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(93, 187);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 18;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(414, 218);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value3txt);
            this.Controls.Add(this.AltBtn);
            this.Controls.Add(this.AltLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Alter Exchange Rate";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AltLbl;
        private System.Windows.Forms.Button AltBtn;
        private System.Windows.Forms.RadioButton DollarBtn4;
        private System.Windows.Forms.RadioButton EuroBtn4;
        private System.Windows.Forms.RadioButton PoundBtn4;
        private System.Windows.Forms.RadioButton DollarBtn3;
        private System.Windows.Forms.RadioButton PoundBtn3;
        private System.Windows.Forms.RadioButton EuroBtn3;
        private System.Windows.Forms.TextBox Value3txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetBtn;
    }
}
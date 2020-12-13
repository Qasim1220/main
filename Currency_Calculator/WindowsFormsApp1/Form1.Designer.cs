namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.Valuetxt = new System.Windows.Forms.TextBox();
            this.DollarBtn = new System.Windows.Forms.RadioButton();
            this.PoundBtn = new System.Windows.Forms.RadioButton();
            this.EuroBtn = new System.Windows.Forms.RadioButton();
            this.Calclbl = new System.Windows.Forms.Label();
            this.ConBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Exchangelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Value2Lbl = new System.Windows.Forms.Label();
            this.Value2txt = new System.Windows.Forms.TextBox();
            this.DollarBtn2 = new System.Windows.Forms.RadioButton();
            this.EuroBtn2 = new System.Windows.Forms.RadioButton();
            this.PoundBtn2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ValueLbl);
            this.panel1.Controls.Add(this.Valuetxt);
            this.panel1.Controls.Add(this.DollarBtn);
            this.panel1.Controls.Add(this.PoundBtn);
            this.panel1.Controls.Add(this.EuroBtn);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 167);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(3, 126);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(48, 17);
            this.ValueLbl.TabIndex = 8;
            this.ValueLbl.Text = "Value:";
            // 
            // Valuetxt
            // 
            this.Valuetxt.Location = new System.Drawing.Point(57, 123);
            this.Valuetxt.Name = "Valuetxt";
            this.Valuetxt.Size = new System.Drawing.Size(100, 22);
            this.Valuetxt.TabIndex = 6;
            this.Valuetxt.TextChanged += new System.EventHandler(this.Valuetxt_TextChanged);
            // 
            // DollarBtn
            // 
            this.DollarBtn.AutoSize = true;
            this.DollarBtn.Location = new System.Drawing.Point(3, 68);
            this.DollarBtn.Name = "DollarBtn";
            this.DollarBtn.Size = new System.Drawing.Size(78, 21);
            this.DollarBtn.TabIndex = 2;
            this.DollarBtn.Text = "Dollar $";
            this.DollarBtn.UseVisualStyleBackColor = true;
            // 
            // PoundBtn
            // 
            this.PoundBtn.AutoSize = true;
            this.PoundBtn.Location = new System.Drawing.Point(3, 41);
            this.PoundBtn.Name = "PoundBtn";
            this.PoundBtn.Size = new System.Drawing.Size(132, 21);
            this.PoundBtn.TabIndex = 1;
            this.PoundBtn.Text = "Pound sterling £";
            this.PoundBtn.UseVisualStyleBackColor = true;
            // 
            // EuroBtn
            // 
            this.EuroBtn.AutoSize = true;
            this.EuroBtn.Location = new System.Drawing.Point(3, 14);
            this.EuroBtn.Name = "EuroBtn";
            this.EuroBtn.Size = new System.Drawing.Size(71, 21);
            this.EuroBtn.TabIndex = 0;
            this.EuroBtn.Text = "Euro €";
            this.EuroBtn.UseVisualStyleBackColor = true;
            // 
            // Calclbl
            // 
            this.Calclbl.AutoSize = true;
            this.Calclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calclbl.Location = new System.Drawing.Point(12, 9);
            this.Calclbl.Name = "Calclbl";
            this.Calclbl.Size = new System.Drawing.Size(223, 29);
            this.Calclbl.TabIndex = 1;
            this.Calclbl.Text = "Currency Calculator";
            // 
            // ConBtn
            // 
            this.ConBtn.Location = new System.Drawing.Point(12, 247);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(75, 23);
            this.ConBtn.TabIndex = 2;
            this.ConBtn.Text = "Convert";
            this.ConBtn.UseVisualStyleBackColor = true;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(303, 247);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(431, 247);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Exchangelbl
            // 
            this.Exchangelbl.AutoSize = true;
            this.Exchangelbl.Location = new System.Drawing.Point(461, 21);
            this.Exchangelbl.Name = "Exchangelbl";
            this.Exchangelbl.Size = new System.Drawing.Size(36, 17);
            this.Exchangelbl.TabIndex = 10;
            this.Exchangelbl.Text = "0.00";
            this.Exchangelbl.Click += new System.EventHandler(this.Exchangelbl_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Value2Lbl);
            this.panel2.Controls.Add(this.Value2txt);
            this.panel2.Controls.Add(this.DollarBtn2);
            this.panel2.Controls.Add(this.EuroBtn2);
            this.panel2.Controls.Add(this.PoundBtn2);
            this.panel2.Location = new System.Drawing.Point(277, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 167);
            this.panel2.TabIndex = 6;
            // 
            // Value2Lbl
            // 
            this.Value2Lbl.AutoSize = true;
            this.Value2Lbl.Location = new System.Drawing.Point(56, 126);
            this.Value2Lbl.Name = "Value2Lbl";
            this.Value2Lbl.Size = new System.Drawing.Size(56, 17);
            this.Value2Lbl.TabIndex = 14;
            this.Value2Lbl.Text = "Value2:";
            // 
            // Value2txt
            // 
            this.Value2txt.Location = new System.Drawing.Point(118, 123);
            this.Value2txt.Name = "Value2txt";
            this.Value2txt.Size = new System.Drawing.Size(100, 22);
            this.Value2txt.TabIndex = 13;
            this.Value2txt.TextChanged += new System.EventHandler(this.Value2txt_TextChanged_1);
            // 
            // DollarBtn2
            // 
            this.DollarBtn2.AutoSize = true;
            this.DollarBtn2.Location = new System.Drawing.Point(140, 68);
            this.DollarBtn2.Name = "DollarBtn2";
            this.DollarBtn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DollarBtn2.Size = new System.Drawing.Size(78, 21);
            this.DollarBtn2.TabIndex = 12;
            this.DollarBtn2.Text = "Dollar $";
            this.DollarBtn2.UseVisualStyleBackColor = true;
            // 
            // EuroBtn2
            // 
            this.EuroBtn2.AutoSize = true;
            this.EuroBtn2.Location = new System.Drawing.Point(147, 14);
            this.EuroBtn2.Name = "EuroBtn2";
            this.EuroBtn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EuroBtn2.Size = new System.Drawing.Size(71, 21);
            this.EuroBtn2.TabIndex = 10;
            this.EuroBtn2.TabStop = true;
            this.EuroBtn2.Text = "Euro €";
            this.EuroBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EuroBtn2.UseVisualStyleBackColor = true;
            // 
            // PoundBtn2
            // 
            this.PoundBtn2.AutoSize = true;
            this.PoundBtn2.Location = new System.Drawing.Point(86, 41);
            this.PoundBtn2.Name = "PoundBtn2";
            this.PoundBtn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PoundBtn2.Size = new System.Drawing.Size(132, 21);
            this.PoundBtn2.TabIndex = 11;
            this.PoundBtn2.TabStop = true;
            this.PoundBtn2.Text = "Pound sterling £";
            this.PoundBtn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(518, 282);
            this.Controls.Add(this.Exchangelbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ConBtn);
            this.Controls.Add(this.Calclbl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Currency Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Calclbl;
        private System.Windows.Forms.Button ConBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Exchangelbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.TextBox Valuetxt;
        private System.Windows.Forms.RadioButton DollarBtn;
        private System.Windows.Forms.RadioButton PoundBtn;
        private System.Windows.Forms.RadioButton EuroBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Value2Lbl;
        private System.Windows.Forms.TextBox Value2txt;
        private System.Windows.Forms.RadioButton DollarBtn2;
        private System.Windows.Forms.RadioButton EuroBtn2;
        private System.Windows.Forms.RadioButton PoundBtn2;
    }
}


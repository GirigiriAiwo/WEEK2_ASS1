namespace Calc2
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
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            bad = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            bsub = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            bmult = new Button();
            ndot = new Button();
            n0 = new Button();
            bc = new Button();
            bdiv = new Button();
            nequal = new Button();
            bce = new Button();
            listBoxInputHistory = new ListBox();
            bPlusMinus = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Courier New", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(18, 35);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(325, 62);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // n1
            // 
            n1.Location = new Point(18, 103);
            n1.Name = "n1";
            n1.Size = new Size(59, 40);
            n1.TabIndex = 2;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.Location = new Point(109, 103);
            n2.Name = "n2";
            n2.Size = new Size(59, 40);
            n2.TabIndex = 3;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.Location = new Point(199, 103);
            n3.Name = "n3";
            n3.Size = new Size(59, 40);
            n3.TabIndex = 4;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // bad
            // 
            bad.Location = new Point(281, 155);
            bad.Name = "bad";
            bad.Size = new Size(59, 40);
            bad.TabIndex = 5;
            bad.Text = "+";
            bad.UseVisualStyleBackColor = true;
            bad.Click += bad_Click;
            // 
            // n4
            // 
            n4.Location = new Point(21, 155);
            n4.Name = "n4";
            n4.Size = new Size(59, 40);
            n4.TabIndex = 6;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.Location = new Point(109, 155);
            n5.Name = "n5";
            n5.Size = new Size(59, 40);
            n5.TabIndex = 7;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.Location = new Point(199, 155);
            n6.Name = "n6";
            n6.Size = new Size(59, 40);
            n6.TabIndex = 8;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            // 
            // bsub
            // 
            bsub.Location = new Point(281, 207);
            bsub.Name = "bsub";
            bsub.Size = new Size(59, 40);
            bsub.TabIndex = 9;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = true;
            bsub.Click += bsub_Click;
            // 
            // n7
            // 
            n7.Location = new Point(21, 217);
            n7.Name = "n7";
            n7.Size = new Size(59, 40);
            n7.TabIndex = 10;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n9_Click;
            // 
            // n8
            // 
            n8.Location = new Point(109, 217);
            n8.Name = "n8";
            n8.Size = new Size(59, 40);
            n8.TabIndex = 11;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.Location = new Point(199, 217);
            n9.Name = "n9";
            n9.Size = new Size(59, 40);
            n9.TabIndex = 19;
            n9.Text = "9";
            n9.Click += n9_Click_1;
            // 
            // bmult
            // 
            bmult.Location = new Point(281, 269);
            bmult.Name = "bmult";
            bmult.Size = new Size(59, 40);
            bmult.TabIndex = 13;
            bmult.Text = "*";
            bmult.UseVisualStyleBackColor = true;
            bmult.Click += bmult_Click;
            // 
            // ndot
            // 
            ndot.Location = new Point(199, 270);
            ndot.Name = "ndot";
            ndot.Size = new Size(59, 40);
            ndot.TabIndex = 14;
            ndot.Text = ".";
            ndot.UseVisualStyleBackColor = true;
            ndot.Click += ndot_Click;
            // 
            // n0
            // 
            n0.Location = new Point(109, 270);
            n0.Name = "n0";
            n0.Size = new Size(59, 40);
            n0.TabIndex = 15;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            // 
            // bc
            // 
            bc.BackColor = Color.OrangeRed;
            bc.Location = new Point(21, 270);
            bc.Name = "bc";
            bc.Size = new Size(59, 40);
            bc.TabIndex = 16;
            bc.Text = "CE";
            bc.UseVisualStyleBackColor = false;
            bc.Click += bc_Click;
            // 
            // bdiv
            // 
            bdiv.Location = new Point(281, 103);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(59, 40);
            bdiv.TabIndex = 17;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = true;
            bdiv.Click += bdiv_Click;
            // 
            // nequal
            // 
            nequal.Location = new Point(357, 201);
            nequal.Name = "nequal";
            nequal.Size = new Size(59, 109);
            nequal.TabIndex = 18;
            nequal.Text = "=";
            nequal.UseVisualStyleBackColor = true;
            nequal.Click += nequal_Click;
            // 
            // bce
            // 
            bce.BackColor = Color.OrangeRed;
            bce.Location = new Point(357, 103);
            bce.Name = "bce";
            bce.Size = new Size(59, 40);
            bce.TabIndex = 20;
            bce.Text = "C";
            bce.UseVisualStyleBackColor = false;
            bce.Click += bce_Click;
            // 
            // listBoxInputHistory
            // 
            listBoxInputHistory.FormattingEnabled = true;
            listBoxInputHistory.HorizontalScrollbar = true;
            listBoxInputHistory.ItemHeight = 15;
            listBoxInputHistory.Location = new Point(100, 10);
            listBoxInputHistory.Name = "listBoxInputHistory";
            listBoxInputHistory.Size = new Size(243, 19);
            listBoxInputHistory.TabIndex = 21;
            // 
            // bPlusMinus
            // 
            bPlusMinus.Location = new Point(357, 149);
            bPlusMinus.Name = "bPlusMinus";
            bPlusMinus.Size = new Size(59, 40);
            bPlusMinus.TabIndex = 22;
            bPlusMinus.Text = "+/-";
            bPlusMinus.UseVisualStyleBackColor = true;
            bPlusMinus.Click += bPlusMinus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 328);
            Controls.Add(bPlusMinus);
            Controls.Add(listBoxInputHistory);
            Controls.Add(bce);
            Controls.Add(textBox1);
            Controls.Add(nequal);
            Controls.Add(bdiv);
            Controls.Add(bc);
            Controls.Add(n0);
            Controls.Add(ndot);
            Controls.Add(bmult);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(bsub);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(bad);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button bad;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button bsub;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button bmult;
        private Button ndot;
        private Button n0;
        private Button bc;
        private Button bdiv;
        private Button nequal;
        private Button bce;
        private ListBox listBoxInputHistory;
        private Button bPlusMinus;
    }
}

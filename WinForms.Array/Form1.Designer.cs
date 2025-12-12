namespace WinForms.Array
{
    partial class txtAvg
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLength = new TextBox();
            txtSum = new TextBox();
            txtAverrage = new TextBox();
            txtMax = new TextBox();
            label5 = new Label();
            txtMin = new TextBox();
            label6 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(293, 371);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(374, 46);
            button1.Name = "button1";
            button1.Size = new Size(98, 52);
            button1.TabIndex = 2;
            button1.Text = "ประมวลผล";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(512, 46);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "จำนวนข้อมูล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(555, 84);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "ผลรวม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(547, 122);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 5;
            label4.Text = "ค่าเฉลี่ย";
            // 
            // txtLength
            // 
            txtLength.BackColor = Color.White;
            txtLength.Location = new Point(622, 51);
            txtLength.Name = "txtLength";
            txtLength.ReadOnly = true;
            txtLength.Size = new Size(155, 23);
            txtLength.TabIndex = 6;
            // 
            // txtSum
            // 
            txtSum.BackColor = Color.White;
            txtSum.Location = new Point(622, 89);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(155, 23);
            txtSum.TabIndex = 7;
            // 
            // txtAverrage
            // 
            txtAverrage.BackColor = Color.White;
            txtAverrage.Location = new Point(622, 124);
            txtAverrage.Name = "txtAverrage";
            txtAverrage.ReadOnly = true;
            txtAverrage.Size = new Size(155, 23);
            txtAverrage.TabIndex = 8;
            // 
            // txtMax
            // 
            txtMax.BackColor = Color.White;
            txtMax.Location = new Point(622, 163);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(155, 23);
            txtMax.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(546, 161);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 9;
            label5.Text = "ค่าสูงสุด";
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.White;
            txtMin.Location = new Point(622, 201);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(155, 23);
            txtMin.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(543, 199);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 11;
            label6.Text = "ค่าต่ำสุด";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.Location = new Point(374, 226);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 13;
            button2.Text = "ทดสอบ Array 2 มิติ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 272);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(403, 145);
            textBox2.TabIndex = 14;
            // 
            // txtAvg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(txtMin);
            Controls.Add(label6);
            Controls.Add(txtMax);
            Controls.Add(label5);
            Controls.Add(txtAverrage);
            Controls.Add(txtSum);
            Controls.Add(txtLength);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "txtAvg";
            Text = "ทดสอบการใช้งาน Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLength;
        private TextBox txtSum;
        private TextBox txtAverrage;
        private TextBox txtMax;
        private Label label5;
        private TextBox txtMin;
        private Label label6;
        private Button button2;
        private TextBox textBox2;
    }
}

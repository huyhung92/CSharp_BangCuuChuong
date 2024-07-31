namespace CSharp_BangCuuChuong
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
            label1 = new Label();
            bcc = new TextBox();
            number = new NumericUpDown();
            kq = new Label();
            label3 = new Label();
            tinh = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            rbo8 = new RadioButton();
            rbo9 = new RadioButton();
            rbo7 = new RadioButton();
            rbo6 = new RadioButton();
            rbo5 = new RadioButton();
            rbo4 = new RadioButton();
            rbo3 = new RadioButton();
            rbo2 = new RadioButton();
            rbo1 = new RadioButton();
            button1 = new Button();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)number).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 69);
            label1.Name = "label1";
            label1.Size = new Size(280, 30);
            label1.TabIndex = 0;
            label1.Text = "Chọn Bảng Cửu Chương";
            label1.Click += label1_Click;
            // 
            // bcc
            // 
            bcc.Location = new Point(355, 61);
            bcc.Name = "bcc";
            bcc.Size = new Size(303, 38);
            bcc.TabIndex = 1;
            bcc.TextChanged += bcc_TextChanged;
            // 
            // number
            // 
            number.Location = new Point(737, 61);
            number.Name = "number";
            number.Size = new Size(150, 38);
            number.TabIndex = 2;
            number.ValueChanged += number_ValueChanged;
            // 
            // kq
            // 
            kq.AutoSize = true;
            kq.Location = new Point(47, 178);
            kq.Name = "kq";
            kq.Size = new Size(102, 30);
            kq.TabIndex = 3;
            kq.Text = "Kết Quả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 178);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // tinh
            // 
            tinh.Location = new Point(355, 358);
            tinh.Name = "tinh";
            tinh.Size = new Size(167, 48);
            tinh.TabIndex = 5;
            tinh.Text = "Tính";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(556, 132);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 334);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbo8);
            groupBox1.Controls.Add(rbo9);
            groupBox1.Controls.Add(rbo7);
            groupBox1.Controls.Add(rbo6);
            groupBox1.Controls.Add(rbo5);
            groupBox1.Controls.Add(rbo4);
            groupBox1.Controls.Add(rbo3);
            groupBox1.Controls.Add(rbo2);
            groupBox1.Controls.Add(rbo1);
            groupBox1.Location = new Point(28, 543);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 180);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbo8
            // 
            rbo8.AutoSize = true;
            rbo8.Location = new Point(200, 117);
            rbo8.Name = "rbo8";
            rbo8.Size = new Size(48, 34);
            rbo8.TabIndex = 9;
            rbo8.TabStop = true;
            rbo8.Text = "8";
            rbo8.UseVisualStyleBackColor = true;
            // 
            // rbo9
            // 
            rbo9.AutoSize = true;
            rbo9.Location = new Point(392, 117);
            rbo9.Name = "rbo9";
            rbo9.Size = new Size(48, 34);
            rbo9.TabIndex = 8;
            rbo9.TabStop = true;
            rbo9.Text = "9";
            rbo9.UseVisualStyleBackColor = true;
            // 
            // rbo7
            // 
            rbo7.AutoSize = true;
            rbo7.Location = new Point(6, 117);
            rbo7.Name = "rbo7";
            rbo7.Size = new Size(48, 34);
            rbo7.TabIndex = 6;
            rbo7.TabStop = true;
            rbo7.Text = "7";
            rbo7.UseVisualStyleBackColor = true;
            // 
            // rbo6
            // 
            rbo6.AutoSize = true;
            rbo6.Location = new Point(392, 77);
            rbo6.Name = "rbo6";
            rbo6.Size = new Size(48, 34);
            rbo6.TabIndex = 5;
            rbo6.TabStop = true;
            rbo6.Text = "6";
            rbo6.UseVisualStyleBackColor = true;
            // 
            // rbo5
            // 
            rbo5.AutoSize = true;
            rbo5.Location = new Point(200, 77);
            rbo5.Name = "rbo5";
            rbo5.Size = new Size(48, 34);
            rbo5.TabIndex = 4;
            rbo5.TabStop = true;
            rbo5.Text = "5";
            rbo5.UseVisualStyleBackColor = true;
            // 
            // rbo4
            // 
            rbo4.AutoSize = true;
            rbo4.Location = new Point(6, 77);
            rbo4.Name = "rbo4";
            rbo4.Size = new Size(48, 34);
            rbo4.TabIndex = 3;
            rbo4.TabStop = true;
            rbo4.Text = "4";
            rbo4.UseVisualStyleBackColor = true;
            // 
            // rbo3
            // 
            rbo3.AutoSize = true;
            rbo3.Location = new Point(392, 37);
            rbo3.Name = "rbo3";
            rbo3.Size = new Size(48, 34);
            rbo3.TabIndex = 2;
            rbo3.TabStop = true;
            rbo3.Text = "3";
            rbo3.UseVisualStyleBackColor = true;
            // 
            // rbo2
            // 
            rbo2.AutoSize = true;
            rbo2.Location = new Point(200, 37);
            rbo2.Name = "rbo2";
            rbo2.Size = new Size(48, 34);
            rbo2.TabIndex = 1;
            rbo2.TabStop = true;
            rbo2.Text = "2";
            rbo2.UseVisualStyleBackColor = true;
            // 
            // rbo1
            // 
            rbo1.AutoSize = true;
            rbo1.Location = new Point(6, 37);
            rbo1.Name = "rbo1";
            rbo1.Size = new Size(48, 34);
            rbo1.TabIndex = 0;
            rbo1.TabStop = true;
            rbo1.Text = "1";
            rbo1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(567, 606);
            button1.Name = "button1";
            button1.Size = new Size(263, 62);
            button1.TabIndex = 8;
            button1.Text = "Xem Lại";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(355, 481);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(346, 56);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 751);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(tinh);
            Controls.Add(label3);
            Controls.Add(kq);
            Controls.Add(number);
            Controls.Add(bcc);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Bảng Cửu Chương";
            ((System.ComponentModel.ISupportInitialize)number).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox bcc;
        private NumericUpDown number;
        private Label kq;
        private Label label3;
        private Button tinh;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private RadioButton rbo9;
        private RadioButton rbo7;
        private RadioButton rbo6;
        private RadioButton rbo5;
        private RadioButton rbo4;
        private RadioButton rbo3;
        private RadioButton rbo2;
        private RadioButton rbo1;
        private RadioButton rbo8;
        private Button button1;
        private TrackBar trackBar1;
    }
}

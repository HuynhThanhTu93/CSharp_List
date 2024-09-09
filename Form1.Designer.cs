namespace CSharp_List
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
            txt_n = new TextBox();
            label2 = new Label();
            txt_le = new TextBox();
            label3 = new Label();
            txt_SNT = new TextBox();
            txt_nhap = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(110, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập n:";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(135, 45);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 40);
            txt_n.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 99);
            label2.Name = "label2";
            label2.Size = new Size(120, 33);
            label2.TabIndex = 0;
            label2.Text = "Các số lẻ";
            // 
            // txt_le
            // 
            txt_le.Location = new Point(151, 92);
            txt_le.Name = "txt_le";
            txt_le.Size = new Size(228, 40);
            txt_le.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(134, 33);
            label3.TabIndex = 0;
            label3.Text = "Các số NT";
            // 
            // txt_SNT
            // 
            txt_SNT.Location = new Point(151, 138);
            txt_SNT.Name = "txt_SNT";
            txt_SNT.Size = new Size(228, 40);
            txt_SNT.TabIndex = 4;
            // 
            // txt_nhap
            // 
            txt_nhap.Location = new Point(264, 45);
            txt_nhap.Name = "txt_nhap";
            txt_nhap.Size = new Size(176, 40);
            txt_nhap.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(25, 207);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 2;
            button1.Text = "Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 89);
            button2.Name = "button2";
            button2.Size = new Size(101, 43);
            button2.TabIndex = 2;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(385, 135);
            button3.Name = "button3";
            button3.Size = new Size(101, 43);
            button3.TabIndex = 2;
            button3.Text = "Tìm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 328);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_SNT);
            Controls.Add(txt_nhap);
            Controls.Add(txt_le);
            Controls.Add(label3);
            Controls.Add(txt_n);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_n;
        private Label label2;
        private TextBox txt_le;
        private Label label3;
        private TextBox txt_SNT;
        private TextBox txt_nhap;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

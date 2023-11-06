namespace Ucak_Bilet_Rezervasyon_Sistemi_Proje2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 264);
            label9.Name = "label9";
            label9.Size = new Size(64, 24);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.Location = new Point(306, 115);
            button2.Name = "button2";
            button2.Size = new Size(64, 29);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(134, 222);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(157, 30);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 222);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 6;
            label4.Text = "Saat : ";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 30);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 24);
            label3.TabIndex = 4;
            label3.Text = "Tarih : ";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana ", "Elazığ", "Samsun" });
            comboBox2.Location = new Point(134, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 32);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana ", "Elazığ", "Samsun" });
            comboBox1.Location = new Point(134, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 32);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 132);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 1;
            label2.Text = "Nereye  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 0;
            label1.Text = "Nereden  : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(498, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(179, 227);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(179, 167);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(132, 30);
            maskedTextBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 162);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 4;
            label7.Text = "Telefon :";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(179, 117);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(132, 30);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 117);
            label6.Name = "label6";
            label6.Size = new Size(51, 24);
            label6.TabIndex = 2;
            label6.Text = "TC : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 30);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 73);
            label5.Name = "label5";
            label5.Size = new Size(163, 24);
            label5.TabIndex = 0;
            label5.Text = "Yolcu Ad Soyad : ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(133, 537);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 100);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(22, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 130);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(549, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(136, 44);
            label8.Name = "label8";
            label8.Size = new Size(325, 44);
            label8.TabIndex = 0;
            label8.Text = "Jüpiter Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 716);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
    }
}
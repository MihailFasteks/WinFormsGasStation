namespace WinFormsGasStation
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label14 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox5 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            checkBox1 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            groupBox6 = new GroupBox();
            label10 = new Label();
            button1 = new Button();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Бензин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 90);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Цена";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label14);
            groupBox1.Location = new Point(118, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(44, 188);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(160, 60);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "До оплати";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 42);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 1;
            label6.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 30);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 0;
            label5.Text = "---";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(104, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(104, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(0, 108);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(100, 74);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сумма";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(8, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Количество";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 90);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 0;
            label4.Text = "грн";
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(106, 92);
            label14.Name = "label14";
            label14.Size = new Size(98, 17);
            label14.TabIndex = 2;
            label14.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(132, 62);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 2;
            label3.Text = "4,00";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(185, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(51, 188);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(160, 60);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "До оплати";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 42);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 1;
            label7.Text = "грн";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 30);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 0;
            label8.Text = "---";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Location = new Point(132, 122);
            label12.Name = "label12";
            label12.Size = new Size(30, 17);
            label12.TabIndex = 2;
            label12.Text = "7,20";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Location = new Point(132, 93);
            label13.Name = "label13";
            label13.Size = new Size(30, 17);
            label13.TabIndex = 2;
            label13.Text = "5,40";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(185, 118);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(62, 23);
            textBox7.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(132, 150);
            label11.Name = "label11";
            label11.Size = new Size(30, 17);
            label11.TabIndex = 2;
            label11.Text = "4,40";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Хот-дог";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 118);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(114, 19);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Картофель-фри";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 92);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Гамбургер";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 147);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Кока-кола";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(419, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 257);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мини-кафе";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(185, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(185, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 4;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(label9);
            groupBox6.Location = new Point(118, 296);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(565, 116);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Всего к оплате";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(510, 87);
            label10.Name = "label10";
            label10.Size = new Size(26, 15);
            label10.TabIndex = 1;
            label10.Text = "грн";
            // 
            // button1
            // 
            button1.Location = new Point(104, 22);
            button1.Name = "button1";
            button1.Size = new Size(135, 80);
            button1.TabIndex = 2;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 55);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 0;
            label9.Text = "---";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BestOli";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private GroupBox groupBox4;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private GroupBox groupBox5;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label13;
        private TextBox textBox7;
        private Label label11;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox6;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}

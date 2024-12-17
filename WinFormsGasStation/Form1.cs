using System.Timers;

namespace WinFormsGasStation
{
    public partial class Form1 : Form
    {
        public int timerS = 0;
        private bool newClientSelected = false;
        private decimal daySum = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Euro-95");
            comboBox1.Items.Add("A-95");
            comboBox1.Items.Add("Euro-DIESEL");
            comboBox1.Items.Add("GAS");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FormClear()
        {
            comboBox1.SelectedIndex = -1;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();

            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            label5.Text = "---";
            label6.Text = "---";
            label8.Text = "---";
            label9.Text = "---";

            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Euro-95":
                    label14.Text = "55,90";
                    break;
                case "A-95":
                    label14.Text = "53,90";
                    break;
                case "Euro-DIESEL":
                    label14.Text = "50,90";
                    break;
                case "GAS":
                    label14.Text = "34,80";
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Text = "100";
                groupBox4.Text = "К оплате";
                label6.Text = "грн";
            }
            else
            {
                textBox1.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Text = "1";
                groupBox4.Text = "К выдаче";
                label6.Text = "л";
            }
            else
            {
                textBox2.Enabled = false;

            }
        }
        private void updateCheckBox(CheckBox cb, TextBox tb)
        {
            tb.Enabled = cb.Checked;
            tb.Text = cb.Checked ? "1" : "";
        }
        private decimal UpdateCafeSum(CheckBox cb, TextBox tb, Label lb)
        {
            decimal tempSum = 0;
            if (cb.Checked)
            {

                tempSum = decimal.Parse(lb.Text) * decimal.Parse(tb.Text);

            }
            return tempSum;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBox(checkBox1, textBox3);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBox(checkBox3, textBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBox(checkBox5, textBox7);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBox(checkBox4, textBox5);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            decimal gsSum = 0;
            decimal lCount;
            if (radioButton1.Checked)
            {
                gsSum = decimal.Parse(label14.Text) * decimal.Parse(textBox1.Text);
                label5.Text = gsSum.ToString("F2");
            }
            else if (radioButton2.Checked)
            {
                gsSum = decimal.Parse(textBox2.Text);
                lCount = decimal.Parse(textBox2.Text) / decimal.Parse(label14.Text);
                label5.Text = lCount.ToString("F2");
            }
            else
            {
                label5.Text = "---";
            }
            decimal cafeSum = 0;
            cafeSum += UpdateCafeSum(checkBox1, textBox3, label3);
            cafeSum += UpdateCafeSum(checkBox3, textBox4, label13);
            cafeSum += UpdateCafeSum(checkBox5, textBox7, label12);
            cafeSum += UpdateCafeSum(checkBox4, textBox5, label11);

            label8.Text = cafeSum.ToString("F2");

            label9.Text = (cafeSum + gsSum).ToString("F2");
            daySum += decimal.Parse(label9.Text);

            timerS = 0;
            timer1.Start();

            if (!newClientSelected)
            {
                timerS = 0;
                timer1.Start();
            }
            else
            {
                newClientSelected = false;
                button1.Enabled = true;
            }
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerS++;
            if (timerS >= 10)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Новый клиент?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newClientSelected = true;
                    FormClear();
                }
                else
                {

                    timerS = 0;
                    timer1.Start();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Ваша сумма за день составляет : {daySum.ToString()}", "Отчет за день", MessageBoxButtons.OK);
        }
    }
}

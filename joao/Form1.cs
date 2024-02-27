namespace joao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string cnpj = textBox1.Text;
            string razão = textBox2.Text;
            string fantasia = textBox3.Text;
            string situaçao = comboBox1.Text;
            string regime = "";
            string data = dateTimePicker1.Text;
            string telefone = maskedTextBox1.Text;
            string capitalsocial = textBox4.Text;
            string endereco = textBox5.Text;
            string estado = comboBox2.Text;
            string numero = textBox6.Text;
            string cidade = textBox7.Text;
            string tipo = "";
            string porte = "";
            string natureza = comboBox3.Text;
            string cpf = maskedTextBox2.Text;

            string nome = textBox8.Text;

            if(radioButton1.Checked == true)
            {
                regime = radioButton1.Text;    
            }
            if (radioButton2.Checked == true)
            {
                regime = radioButton1.Text;
            }
            if (radioButton3.Checked == true)
            {
                regime = radioButton1.Text;
            }
            if (radioButton4.Checked == true)
            {
                regime = radioButton1.Text;
            }
            if (radioButton5.Checked == true)
            {
                tipo = radioButton5.Text;
            }
            if (radioButton6.Checked == true)
            {
                tipo = radioButton6.Text;
            }
            if (radioButton7.Checked == true)
            {
                porte = radioButton7.Text;
            }
            if (radioButton8.Checked == true)
            {
               porte = radioButton8.Text;
            }
           
            if (radioButton10.Checked == true)
            {
                porte = radioButton10.Text;
            }
            MessageBox.Show(cnpj + " " + razão + "" + fantasia + "" +  situaçao + "" + regime + "" + data +" " + "" + telefone + "" +capitalsocial + "" +estado + " " + numero + "" +cidade + "" + tipo +"" + porte + "" + natureza + "" +cpf + "" +nome);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
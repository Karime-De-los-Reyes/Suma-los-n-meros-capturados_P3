namespace Suma_los_números_capturados_3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Añadir
            listBox1.Items.Add(textBox1.Text);
            //Aquí es donde pasamos el parámetro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón sumatoria
            textBox2.Text = Total.ToString();
        }
    }
}
namespace Tarea2_EsPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodigoFlow.EsPrimo(int.Parse(textBox1.Text));
        }
    }
}

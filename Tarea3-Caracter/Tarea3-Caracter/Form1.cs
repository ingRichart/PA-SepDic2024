namespace Tarea3_Caracter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodigoFlow.LeerCaracter(textBox1.Text);
        }
    }
}

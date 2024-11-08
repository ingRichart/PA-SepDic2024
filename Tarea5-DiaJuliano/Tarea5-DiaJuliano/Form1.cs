namespace Tarea5_DiaJuliano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var respuesta = CodigoFlow.DiaJuliano(
                    int.Parse(textBox1.Text), 
                    int.Parse(textBox2.Text), 
                    int.Parse(textBox3.Text));  


            MessageBox.Show("El dia juliano es: " + respuesta);
        }

    }
}

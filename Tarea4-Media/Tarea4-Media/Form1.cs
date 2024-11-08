namespace Tarea4_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resp = CodigoFlow.Media(numeric1.Value, numeric2.Value);

            MessageBox.Show("La media es:" + resp);
        }
    }
}

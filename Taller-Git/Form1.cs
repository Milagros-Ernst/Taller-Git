namespace Taller_Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo 2");
            int numero = 1;
            MessageBox.Show($"El numero es:{numero}");
        }
    }
}

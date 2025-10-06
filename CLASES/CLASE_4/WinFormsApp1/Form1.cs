namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCrearFormulario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creando un nuevo formulario...");
            Form nuevoForm = new Form();
            nuevoForm.Text = "Nuevo Formulario";
            nuevoForm.Width = 800;
            nuevoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultado =
                    this.numOperando1.Value / this.numOperando.Value;
                this.txResultado.Text = resultado.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxButtons.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxButtons.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
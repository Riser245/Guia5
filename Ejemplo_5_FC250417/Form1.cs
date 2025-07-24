namespace Ejemplo_5_FC250417
{
    public partial class Form1 : Form
    {
        private empleado miEmpleado;

        public Form1()
        {
            InitializeComponent();
            miEmpleado = new empleado();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradasEmpleado())
            {
                return;
            }
            miEmpleado.Nombre = txtnombre.Text;
            miEmpleado.Identificacion = txtidentificacion.Text;
            miEmpleado.SalarioDiario = decimal.Parse(txtdiario.Text);
            MessageBox.Show("Datos guardados correctamente.");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdias.Text))
            {
                MessageBox.Show("Ingrese los dias trabajados.");
                return;
            }

            int dias;
            if (int.TryParse(txtdias.Text, out dias) && dias >= 0)
            {
                decimal total = miEmpleado.CalcularSalario(dias);
                txtsalario.Text = total.ToString();

            }
            else
            {
                MessageBox.Show("Ingrese un número válido de dias .");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
            txtdiario.Clear();
            txtsalario.Clear();
            txtnombre.Focus();

            miEmpleado = new empleado();
        }

        private bool ValidarEntradasEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text)||
                string.IsNullOrWhiteSpace(txtidentificacion.Text)||
                string.IsNullOrWhiteSpace(txtdiario.Text))
            {
                MessageBox.Show("Complete todos los campos del empleado.");
                return false;
            }

            decimal salario;
            if (!decimal.TryParse(txtdias.Text, out salario) || salario < 0)
            {
                MessageBox.Show("Ingrese un salario diario válido.");
                return false;
            }
            return true;
        }
    }
}
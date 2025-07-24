namespace Ejemplo5._2_FC250417
{
    public partial class Form1 : Form
    {
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Dgvcontactos.DataSource = null;
            Dgvcontactos.DataSource = Personas;
        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
        }

        private void Dgvcontactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = Dgvcontactos.SelectedRows[0];
            int pos = Dgvcontactos.Rows.IndexOf(seleccion);
            edit_indice = pos;

            Persona per = Personas[pos];

            txtnombre.Text = per.Nombre;
            txtapellido.Text = per.Apellido;
            txtcorreo.Text = per.Correo;
            txttelefono.Text = per.Telefono;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Nombre = txtnombre.Text;    
            per.Apellido = txtapellido.Text;
            per.Telefono = txttelefono.Text;
            per.Correo = txtcorreo.Text;

            if(edit_indice > -1)
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                Personas.Add(per);
            }
            actualizarGrid();
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(edit_indice > -1)
            {
                Personas.RemoveAt(edit_indice);
                edit_indice = -1;
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar click primero sobre contacto");
            }
        }
    }
}
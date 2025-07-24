namespace Ejemplo5_complementario_FC250417
{

    public partial class Form1 : Form
    {
        private List<telefono> telefonos = new List<telefono>();
        private int edit_indice = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Dgvcontactos.DataSource = null;
            Dgvcontactos.DataSource = telefonos;
        }

        private void limpiar()
        {
            txtmarca.Clear();
            txtmodelo.Clear();
            txtcolor.Clear();
            txtcap.Clear();
            txtcam.Clear();
            txtvel.Clear();
            txtbateria.Clear();
        }

        private void Dgvcontactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow seleccion = Dgvcontactos.SelectedRows[0];
            int pos = Dgvcontactos.Rows.IndexOf(seleccion);
            edit_indice = pos;

            telefono tel = telefonos[pos];

            txtmarca.Text = tel.Marca;
            txtmodelo.Text = tel.Modelo;
            txtcolor.Text = tel.Color;
            txtcap.Text = tel.CapRam;
            txtcam.Text = tel.Cámara;
            txtvel.Text = tel.Velproc;
            txtbateria.Text = tel.Batería;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            telefono tel = new telefono();
            tel.Marca = txtmarca.Text;
            tel.Modelo = txtmodelo.Text;
            tel.Color = txtcolor.Text;
            tel.CapRam = txtcap.Text;
            tel.Cámara = txtcam.Text;
            tel.Velproc = txtvel.Text;
            tel.Batería = txtbateria.Text;


            if (edit_indice > -1)
            {
                telefonos[edit_indice] = tel;
                edit_indice = -1;
            }
            else
            {
                telefonos.Add(tel);
            }
            actualizarGrid();
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                telefonos.RemoveAt(edit_indice);
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
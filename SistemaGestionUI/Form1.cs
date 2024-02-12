using SistemaGestionBussiness;
using SistemaGestionData.Data;
using SistemaGestionData.Exceptions;
using SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class newUserBtn : Form
    {
        public newUserBtn()
        {
            InitializeComponent();
            GetUsuariosList();
            GetProductosList();
            GetVentasList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region Labels
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        #endregion


        #region TextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetUsuariosList()
        {
            try
            {
                List<Usuario> listaDeUsuarios = UsuarioBussiness.GetUsuarios();

                if (listaDeUsuarios.Count != 0)
                {
                    dataGridListUsers.DataSource = listaDeUsuarios;
                }
                else
                {
                    dataGridListUsers.DataSource= null;
                    dataGridListUsers.Rows.Add("La lista de usuarios está vacia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:", ex.Message);
            }
        }

        private void GetProductosList()
        {
            try
            {
                List<Producto> listaDeProductos = ProductoBussiness.GetProductos();

                if (listaDeProductos.Count == 0)
                {
                    listBox1.Items.Add("No hay productos en la lista.");
                }
                else
                {
                    // listBox1.Items.Add(listaDeProductos);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:", ex.Message);
            }
        }
        private void GetVentasList()
        {
            try
            {
                List<Venta> listaDeVentas = VentaBussiness.GetVentas();

                if (listaDeVentas.Count == 0)
                {
                    listBox1.Items.Add("No hay ventas en la lista.");
                }
                else
                {
                    listBox1.Items.Add(listaDeVentas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:", ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

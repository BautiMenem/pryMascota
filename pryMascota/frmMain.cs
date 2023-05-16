using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMascota
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMascotas.Text == "Perro")
            {

                ptMascotas.Image = Image.FromFile("perro.jpeg");
                lblTipo.Visible = true;
                lblEdad.Visible = true;

            }
            else
            {
                if (listMascotas.Text == "Gato")
                {
                    ptMascotas.Image = Image.FromFile("gato.jpg");
                    lblTipo.Visible = true;
                    lblEdad.Visible = true;
                }
                else
                {
                    if (listMascotas.Text == "Tortuga")
                    {
                        ptMascotas.Image = Image.FromFile("Tortuga-de-tierra.jpg");
                        lblTipo.Visible = true;
                        lblEdad.Visible = true;
                    }
                    else
                    {
                        if (listMascotas.Text == "Hamster")
                        {
                            ptMascotas.Image = Image.FromFile("hamster.jpeg");
                            lblTipo.Visible = true;
                            lblEdad.Visible = true;
                        }
                        
                    }
                   
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] GuardarNombre = new string[10];

            ClsMascota NuevaMascota = new ClsMascota();
            NuevaMascota.nombre = txtNombre.Text;
            NuevaMascota.edad = txtEdad.Text;
            NuevaMascota.tipoAnimal = lstTipo.Text;
            List<ClsMascota> ListarMascotas = new List<ClsMascota>();
            ListarMascotas.Add(NuevaMascota);

            foreach (var item in ListarMascotas)
            {
                listMascotas.Items.Add(item.tipoAnimal);
            }

            txtNombre.Clear();
            txtEdad.Clear();
            lstTipo.SelectedIndex = -1;

        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            ClsMascota Cuidar = new ClsMascota();
            Cuidar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Cuidar.CuidarMascota());
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            ClsMascota Alimentar = new ClsMascota();
            Alimentar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Alimentar.AlimentarMascota());
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ClsMascota Jugar = new ClsMascota();
            Jugar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Jugar.JugarMascota());
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

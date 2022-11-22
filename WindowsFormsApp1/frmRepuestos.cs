using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRepuestos : Form
    {
        // declaración de la estructura para los turnos
        public struct Repuestos
        {
            public string strMarca;
            public string strOrigen;
            public int intNumero;
            public string strDescripcion;
            public float floPrecio;
        }
        // variable para controlar la cantidad de elementos cargados

        Repuestos[] vecRepuestos = new Repuestos[100];
        public int intRegistro = 0;
        public int intConsulta = 0;
        public void LimpiarControles()
        {
            cmbMarca.SelectedIndex = -1;
            optNacional.Checked = true;
            txtNumero.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void mrcDatosRepuestos_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                
                txtDescripcion.Enabled = true;
            }
            else
            {
                
                txtDescripcion.Enabled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            bool existeNroRepuesto = false;
            intConsulta = 0;
            while (intConsulta < vecRepuestos.Length)
            {
                if (vecRepuestos[intConsulta].intNumero == int.Parse(txtNumero.Text))
                {
                    existeNroRepuesto = true;
                    MessageBox.Show("El Nº de Repuesto " + txtNumero.Text +
                    " ya está registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                intConsulta++;
            }
            if (existeNroRepuesto == false)
            {
                vecRepuestos[intRegistro].strMarca = cmbMarca.Text;
                if (optNacional.Checked == true)
                {
                    vecRepuestos[intRegistro].strOrigen = "Nacional";
                }
                else
                {
                    vecRepuestos[intRegistro].strOrigen = "Importado";
                }

                vecRepuestos[intRegistro].intNumero = int.Parse(txtNumero.Text);
                vecRepuestos[intRegistro].strDescripcion = txtDescripcion.Text;
                vecRepuestos[intRegistro].floPrecio = float.Parse(txtPrecio.Text);
                intRegistro++;
                MessageBox.Show("Repuesto Ingresado Correctamente!", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mrcRepuestosIngresados.Enabled = true;
                LimpiarControles();
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            lstConsultaDatos.Items.Clear();
            intConsulta = 0;
            if (optConsultaNacional.Checked == true)
            {
                lstConsultaDatos.Items.Add("Repuestos " + cmbConsultaMarca.Text + " Origen Nacional:");
                lstConsultaDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                while (intConsulta < vecRepuestos.Length)
                {
                    if (vecRepuestos[intConsulta].strMarca == cmbConsultaMarca.Text)
                    {
                        if (vecRepuestos[intConsulta].strOrigen == "Nacional")
                        {
                            lstConsultaDatos.Items.Add("Nº de Repuesto: " + vecRepuestos[intConsulta].intNumero);
                            lstConsultaDatos.Items.Add("Precio: " + vecRepuestos[intConsulta].floPrecio);
                            lstConsultaDatos.Items.Add("Descripción: " + vecRepuestos[intConsulta].strDescripcion);
                            lstConsultaDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                        }
                    }
                    intConsulta++;
                }
            }
            else
            {
                lstConsultaDatos.Items.Add("Repuestos " + cmbConsultaMarca.Text + " Origen Importado");
                lstConsultaDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                while (intConsulta < vecRepuestos.Length)
                {
                    if (vecRepuestos[intConsulta].strMarca == cmbConsultaMarca.Text)
                    {
                        if (vecRepuestos[intConsulta].strOrigen == "Importado")
                        {
                            lstConsultaDatos.Items.Add("Nº de Repuesto: " + vecRepuestos[intConsulta].intNumero);
                            lstConsultaDatos.Items.Add("Precio: " + vecRepuestos[intConsulta].floPrecio);
                            lstConsultaDatos.Items.Add("Descripción: " + vecRepuestos[intConsulta].strDescripcion);
                            lstConsultaDatos.Items.Add("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                        }
                    }
                    intConsulta++;
                }
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
              
                txtNumero.Enabled = true;
            }
            else
            {
               
                txtNumero.Enabled = false;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                
                txtPrecio.Enabled = true;
            }
            else
            {
               
                txtPrecio.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
               cmdRegistrar.Enabled = false;
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            lstConsultaDatos.Items.Clear();
        }

        private void cmbConsultaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultaMarca.SelectedIndex != -1)
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
               cmdConsultar.Enabled = false;
            }
        }
    }
    
}

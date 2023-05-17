using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class frmAgendar : Form
    {
        GestionDB DB = new GestionDB();
        string mensaje;
        public frmAgendar()
        {
            InitializeComponent();
        }

        private void frmAgendar_Load(object sender, EventArgs e)
        {
            var docentes = DB.ListarDocentes();
            cbDocente.DataSource = docentes;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita();
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtAsunto.Text) ||
                string.IsNullOrEmpty(cbHora.Text))
            {
                MessageBox.Show("Por favor no deje campos sin llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cita.nombre_est = txtNombre.Text;
                    cita.docente = cbDocente.SelectedIndex + 1;
                    cita.fecha_deseada = DateTime.Parse(cbFecha.Text);
                    cita.hora = TimeSpan.Parse(cbHora.Text);
                    cita.tema = txtAsunto.Text;
                    var i = DB.GuardarCita(cita);
                    if (i > 0)
                        MessageBox.Show("Cita agendada con exito");
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                Limpiar();
            }
        }
        public override string ToString()
        {
            return mensaje;
        }

        void Limpiar()
        {
            txtNombre.Text = "";
            txtAsunto.Text = "";
            cbHora.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
    }
}

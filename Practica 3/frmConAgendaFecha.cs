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
    public partial class frmConAgendaFecha : Form
    {
        GestionDB Db = new GestionDB();
        public frmConAgendaFecha()
        {
            InitializeComponent();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            var listaCitas = Db.BuscarFecha(DateTime.Parse(cbFecha.Text));
            if (listaCitas.Count > 0)
            {
                datCitas.DataSource = listaCitas;
            }
            else
            {
                MessageBox.Show("No hay cirtas programadas para la fecha seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmConAgendaFecha_Load(object sender, EventArgs e)
        {

        }
    }
}

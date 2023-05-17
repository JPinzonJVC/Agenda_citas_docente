using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Practica_3
{
    public partial class frmConAgendaDoc : Form
    {
        GestionDB Db = new GestionDB();
        public frmConAgendaDoc()
        {

            InitializeComponent();
        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            var listaCitas = Db.BuscarDoc(cbBuscarDocente.SelectedIndex + 1);
            if (listaCitas.Count > 0)
            {
                datCitas.DataSource = listaCitas;
            }
            else
            {
                MessageBox.Show("No hay cirtas programadas con este Docente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmConAgendaDoc_Load(object sender, EventArgs e)
        {
            var docentes = Db.ListarDocentes();
            cbBuscarDocente.DataSource = docentes;
        }
    }
}

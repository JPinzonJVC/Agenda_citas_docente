namespace Practica_3
{
    public partial class FrmPrincipal : MaterialSkin.Controls.MaterialForm
    {

        GestionDB gestion = new GestionDB();
        public FrmPrincipal()
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Yellow600, MaterialSkin.Primary.Grey800,
            MaterialSkin.Primary.Grey800, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmAgendar agendar = new frmAgendar();
            AbrirFormulario(agendar);
        }

        void AbrirFormulario(Form form)
        {


            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnConsAgendaFecha_Click(object sender, EventArgs e)
        {
            frmConAgendaFecha conAgendaFecha = new frmConAgendaFecha();
            AbrirFormulario(conAgendaFecha);
        }

        private void btnConsAgendaDoc_Click(object sender, EventArgs e)
        {
            frmConAgendaDoc conAgendaDoc = new frmConAgendaDoc();
            AbrirFormulario(conAgendaDoc);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
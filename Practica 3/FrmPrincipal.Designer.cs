namespace Practica_3
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgendar = new MaterialSkin.Controls.MaterialButton();
            this.btnConsAgendaFecha = new MaterialSkin.Controls.MaterialButton();
            this.btnConsAgendaDoc = new MaterialSkin.Controls.MaterialButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgendar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgendar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgendar.Depth = 0;
            this.btnAgendar.HighEmphasis = true;
            this.btnAgendar.Icon = null;
            this.btnAgendar.Location = new System.Drawing.Point(-4, 248);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgendar.Size = new System.Drawing.Size(228, 36);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar cita con docente";
            this.btnAgendar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgendar.UseAccentColor = false;
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnConsAgendaFecha
            // 
            this.btnConsAgendaFecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsAgendaFecha.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsAgendaFecha.Depth = 0;
            this.btnConsAgendaFecha.HighEmphasis = true;
            this.btnConsAgendaFecha.Icon = null;
            this.btnConsAgendaFecha.Location = new System.Drawing.Point(-4, 308);
            this.btnConsAgendaFecha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsAgendaFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsAgendaFecha.Name = "btnConsAgendaFecha";
            this.btnConsAgendaFecha.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsAgendaFecha.Size = new System.Drawing.Size(250, 36);
            this.btnConsAgendaFecha.TabIndex = 1;
            this.btnConsAgendaFecha.Text = "Consultar agenda por fecha";
            this.btnConsAgendaFecha.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsAgendaFecha.UseAccentColor = false;
            this.btnConsAgendaFecha.UseVisualStyleBackColor = true;
            this.btnConsAgendaFecha.Click += new System.EventHandler(this.btnConsAgendaFecha_Click);
            // 
            // btnConsAgendaDoc
            // 
            this.btnConsAgendaDoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsAgendaDoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsAgendaDoc.Depth = 0;
            this.btnConsAgendaDoc.HighEmphasis = true;
            this.btnConsAgendaDoc.Icon = null;
            this.btnConsAgendaDoc.Location = new System.Drawing.Point(-2, 376);
            this.btnConsAgendaDoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsAgendaDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsAgendaDoc.Name = "btnConsAgendaDoc";
            this.btnConsAgendaDoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsAgendaDoc.Size = new System.Drawing.Size(270, 36);
            this.btnConsAgendaDoc.TabIndex = 2;
            this.btnConsAgendaDoc.Text = "Consultar agenda por docente";
            this.btnConsAgendaDoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsAgendaDoc.UseAccentColor = false;
            this.btnConsAgendaDoc.UseVisualStyleBackColor = true;
            this.btnConsAgendaDoc.Click += new System.EventHandler(this.btnConsAgendaDoc_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelContenedor.Controls.Add(this.pictureBox2);
            this.PanelContenedor.Location = new System.Drawing.Point(284, 64);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(683, 502);
            this.PanelContenedor.TabIndex = 3;
            // 
            // pbFondo
            // 
            this.pbFondo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbFondo.Location = new System.Drawing.Point(-1, 64);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(288, 499);
            this.pbFondo.TabIndex = 4;
            this.pbFondo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica_3.Properties.Resources.Fondo;
            this.pictureBox2.Location = new System.Drawing.Point(-72, -22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(827, 546);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.btnConsAgendaDoc);
            this.Controls.Add(this.btnConsAgendaFecha);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.pbFondo);
            this.Name = "FrmPrincipal";
            this.Text = "Menu ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgendar;
        private MaterialSkin.Controls.MaterialButton btnConsAgendaFecha;
        private MaterialSkin.Controls.MaterialButton btnConsAgendaDoc;
        private Panel PanelContenedor;
        private PictureBox pbFondo;
        private PictureBox pictureBox2;
    }
}
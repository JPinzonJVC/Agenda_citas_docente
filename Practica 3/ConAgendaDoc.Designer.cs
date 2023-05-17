namespace Practica_3
{
    partial class frmConAgendaDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDocente = new MaterialSkin.Controls.MaterialLabel();
            this.cbBuscarDocente = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscarDoc = new System.Windows.Forms.Button();
            this.datCitas = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Depth = 0;
            this.lblDocente.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDocente.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblDocente.Location = new System.Drawing.Point(31, 32);
            this.lblDocente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(146, 17);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "Seleccione un Docente";
            // 
            // cbBuscarDocente
            // 
            this.cbBuscarDocente.AutoResize = false;
            this.cbBuscarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbBuscarDocente.Depth = 0;
            this.cbBuscarDocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBuscarDocente.DropDownHeight = 174;
            this.cbBuscarDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarDocente.DropDownWidth = 121;
            this.cbBuscarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBuscarDocente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBuscarDocente.FormattingEnabled = true;
            this.cbBuscarDocente.IntegralHeight = false;
            this.cbBuscarDocente.ItemHeight = 43;
            this.cbBuscarDocente.Location = new System.Drawing.Point(194, 12);
            this.cbBuscarDocente.MaxDropDownItems = 4;
            this.cbBuscarDocente.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBuscarDocente.Name = "cbBuscarDocente";
            this.cbBuscarDocente.Size = new System.Drawing.Size(250, 49);
            this.cbBuscarDocente.StartIndex = 0;
            this.cbBuscarDocente.TabIndex = 3;
            // 
            // btnBuscarDoc
            // 
            this.btnBuscarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarDoc.Image = global::Practica_3.Properties.Resources.icons8_search_16;
            this.btnBuscarDoc.Location = new System.Drawing.Point(450, 21);
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.Size = new System.Drawing.Size(31, 28);
            this.btnBuscarDoc.TabIndex = 6;
            this.btnBuscarDoc.UseVisualStyleBackColor = true;
            this.btnBuscarDoc.Click += new System.EventHandler(this.btnBuscarDoc_Click);
            // 
            // datCitas
            // 
            this.datCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datCitas.Location = new System.Drawing.Point(31, 83);
            this.datCitas.Name = "datCitas";
            this.datCitas.RowTemplate.Height = 25;
            this.datCitas.Size = new System.Drawing.Size(680, 281);
            this.datCitas.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica_3.Properties.Resources.Fondo;
            this.pictureBox2.Location = new System.Drawing.Point(-13, -48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(827, 546);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // frmConAgendaDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datCitas);
            this.Controls.Add(this.btnBuscarDoc);
            this.Controls.Add(this.cbBuscarDocente);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConAgendaDoc";
            this.Text = "ConAgendaDoc";
            this.Load += new System.EventHandler(this.frmConAgendaDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblDocente;
        private MaterialSkin.Controls.MaterialComboBox cbBuscarDocente;
        private Button btnBuscarDoc;
        private DataGridView datCitas;
        private PictureBox pictureBox2;
    }
}
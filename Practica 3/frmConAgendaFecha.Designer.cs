namespace Practica_3
{
    partial class frmConAgendaFecha
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.datCitas = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(12, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 17);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Seleccione una fecha";
            // 
            // cbFecha
            // 
            this.cbFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbFecha.Location = new System.Drawing.Point(165, 26);
            this.cbFecha.MinDate = new System.DateTime(2022, 11, 12, 14, 35, 2, 0);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(115, 23);
            this.cbFecha.TabIndex = 4;
            this.cbFecha.Value = new System.DateTime(2022, 11, 12, 14, 35, 2, 0);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarFecha.Image = global::Practica_3.Properties.Resources.icons8_search_16;
            this.btnBuscarFecha.Location = new System.Drawing.Point(295, 25);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(31, 28);
            this.btnBuscarFecha.TabIndex = 5;
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // datCitas
            // 
            this.datCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datCitas.Location = new System.Drawing.Point(12, 64);
            this.datCitas.Name = "datCitas";
            this.datCitas.RowTemplate.Height = 25;
            this.datCitas.Size = new System.Drawing.Size(680, 281);
            this.datCitas.TabIndex = 6;
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
            // frmConAgendaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datCitas);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConAgendaFecha";
            this.Text = "frmConAgendaFecha";
            this.Load += new System.EventHandler(this.frmConAgendaFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DateTimePicker cbFecha;
        private Button btnBuscarFecha;
        private DataGridView datCitas;
        private PictureBox pictureBox2;
    }
}
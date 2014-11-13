namespace Presentacion
{
    partial class frmInformeMaterias
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
            this.btnInforme = new System.Windows.Forms.Button();
            this.crvDatos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInforme
            // 
            this.btnInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInforme.Location = new System.Drawing.Point(602, 306);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(146, 28);
            this.btnInforme.TabIndex = 0;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // crvDatos
            // 
            this.crvDatos.ActiveViewIndex = -1;
            this.crvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crvDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDatos.Location = new System.Drawing.Point(12, 69);
            this.crvDatos.Name = "crvDatos";
            this.crvDatos.Size = new System.Drawing.Size(736, 215);
            this.crvDatos.TabIndex = 1;
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(627, 25);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonas.TabIndex = 2;
            // 
            // lblPersonas
            // 
            this.lblPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(569, 28);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "Personas";
            // 
            // frmInformeMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 357);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.cmbPersonas);
            this.Controls.Add(this.crvDatos);
            this.Controls.Add(this.btnInforme);
            this.Name = "frmInformeMaterias";
            this.Text = "Informe Materias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInforme;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDatos;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label lblPersonas;
    }
}
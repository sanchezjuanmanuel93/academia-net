namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mnuUsuarios,
            this.mnuPermisos,
            this.mnuPersonas,
            this.mnuMaterias,
            this.mnuComisiones,
            this.mnuInscripciones,
            this.mnuEspecialidades,
            this.mnuPlanes});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "mnuPrincipal";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIngresar,
            this.toolStripMenuItem1,
            this.mnuSalir});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // mnuIngresar
            // 
            this.mnuIngresar.Name = "mnuIngresar";
            this.mnuIngresar.ShortcutKeyDisplayString = "F2";
            this.mnuIngresar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuIngresar.Size = new System.Drawing.Size(142, 22);
            this.mnuIngresar.Text = "Ingresar";
            this.mnuIngresar.Click += new System.EventHandler(this.mnuIngresar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.ShortcutKeyDisplayString = "Ctrl + S";
            this.mnuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSalir.Size = new System.Drawing.Size(142, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPermisos
            // 
            this.mnuPermisos.Name = "mnuPermisos";
            this.mnuPermisos.Size = new System.Drawing.Size(67, 20);
            this.mnuPermisos.Text = "Permisos";
            this.mnuPermisos.Click += new System.EventHandler(this.mnuPermisos_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(66, 20);
            this.mnuPersonas.Text = "Personas";
            this.mnuPersonas.Click += new System.EventHandler(this.mnuPersonas_Click);
            // 
            // mnuMaterias
            // 
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(64, 20);
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Click += new System.EventHandler(this.mnuMaterias_Click);
            // 
            // mnuComisiones
            // 
            this.mnuComisiones.Name = "mnuComisiones";
            this.mnuComisiones.Size = new System.Drawing.Size(81, 20);
            this.mnuComisiones.Text = "Comisiones";
            // 
            // mnuInscripciones
            // 
            this.mnuInscripciones.AccessibleDescription = "Personas_Materias";
            this.mnuInscripciones.Name = "mnuInscripciones";
            this.mnuInscripciones.Size = new System.Drawing.Size(88, 20);
            this.mnuInscripciones.Text = "Inscripciones";
            this.mnuInscripciones.Click += new System.EventHandler(this.mnuInscripciones_Click);
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(95, 20);
            this.mnuEspecialidades.Text = "Especialidades";
            // 
            // mnuPlanes
            // 
            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(53, 20);
            this.mnuPlanes.Text = "Planes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 398);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuIngresar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuPermisos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuComisiones;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;
        private System.Windows.Forms.ToolStripMenuItem mnuInscripciones;
    }
}


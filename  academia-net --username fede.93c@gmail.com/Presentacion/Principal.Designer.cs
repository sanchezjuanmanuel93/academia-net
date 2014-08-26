namespace Presentacion
{
    partial class Principal
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
            this.mnuAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAñadirUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAñadirAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAñadirMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mnuAñadir,
            this.asdToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(518, 24);
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
            // mnuAñadir
            // 
            this.mnuAñadir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAñadirUsuario,
            this.mnuAñadirAlumno,
            this.mnuAñadirMateria,
            this.especialidadToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.comisionToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.mnuAñadir.Enabled = false;
            this.mnuAñadir.Name = "mnuAñadir";
            this.mnuAñadir.Size = new System.Drawing.Size(54, 20);
            this.mnuAñadir.Text = "Añadir";
            // 
            // mnuAñadirUsuario
            // 
            this.mnuAñadirUsuario.Name = "mnuAñadirUsuario";
            this.mnuAñadirUsuario.Size = new System.Drawing.Size(152, 22);
            this.mnuAñadirUsuario.Text = "Usuario";
            this.mnuAñadirUsuario.Click += new System.EventHandler(this.mnuAñadirUsuario_Click);
            // 
            // mnuAñadirAlumno
            // 
            this.mnuAñadirAlumno.Name = "mnuAñadirAlumno";
            this.mnuAñadirAlumno.Size = new System.Drawing.Size(152, 22);
            this.mnuAñadirAlumno.Text = "Alumno";
            // 
            // mnuAñadirMateria
            // 
            this.mnuAñadirMateria.Name = "mnuAñadirMateria";
            this.mnuAñadirMateria.Size = new System.Drawing.Size(152, 22);
            this.mnuAñadirMateria.Text = "Materia";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // comisionToolStripMenuItem
            // 
            this.comisionToolStripMenuItem.Name = "comisionToolStripMenuItem";
            this.comisionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comisionToolStripMenuItem.Text = "Comision";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.asdToolStripMenuItem.Text = "asd";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 398);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "Principal";
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
        private System.Windows.Forms.ToolStripMenuItem mnuAñadir;
        private System.Windows.Forms.ToolStripMenuItem mnuAñadirUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuAñadirAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnuAñadirMateria;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
    }
}


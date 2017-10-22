namespace InterfacesDeUsuarioBodegAPP
{
    partial class IUMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.iGVToolStripMenuItem,
            this.cerrarSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Sistema32x32;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarPasswordToolStripMenuItem,
            this.gestionarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Usuarios32x32;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // iGVToolStripMenuItem
            // 
            this.iGVToolStripMenuItem.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.MonedaIGV32x32;
            this.iGVToolStripMenuItem.Name = "iGVToolStripMenuItem";
            this.iGVToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.iGVToolStripMenuItem.Text = "Gestionar IGV";
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Cancelar32x32;
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema";
            // 
            // cambiarPasswordToolStripMenuItem
            // 
            this.cambiarPasswordToolStripMenuItem.Name = "cambiarPasswordToolStripMenuItem";
            this.cambiarPasswordToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.cambiarPasswordToolStripMenuItem.Text = "Cambiar Password";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            // 
            // IUMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IUMenuPrincipal";
            this.Text = "Menu Principal - BodegAPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
    }
}
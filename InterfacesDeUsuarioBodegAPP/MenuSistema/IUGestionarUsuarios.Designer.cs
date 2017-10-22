namespace InterfacesDeUsuarioBodegAPP.MenuSistema
{
    partial class IUGestionarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUGestionarUsuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 404);
            this.dataGridView1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Responsable";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 24);
            this.textBox1.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Editar32x32;
            this.btnEditar.Location = new System.Drawing.Point(776, 202);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 42);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.AutoSize = true;
            this.btnNuevoUsuario.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Nuevo32x32;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(776, 135);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(176, 42);
            this.btnNuevoUsuario.TabIndex = 11;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.AutoSize = true;
            this.btnDesactivar.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Cancelar32x32;
            this.btnDesactivar.Location = new System.Drawing.Point(776, 270);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(176, 42);
            this.btnDesactivar.TabIndex = 16;
            this.btnDesactivar.Text = "Desactivar Usuario";
            this.btnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // IUGestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 498);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IUGestionarUsuarios";
            this.Text = "Gestionar Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesactivar;
    }
}
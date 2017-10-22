namespace InterfacesDeUsuarioBodegAPP.MenuSistema
{
    partial class IUFormularioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUFormularioUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonaResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnAdministrador = new System.Windows.Forms.RadioButton();
            this.rbtnOperador = new System.Windows.Forms.RadioButton();
            this.btnGrabarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.UsuarioFormulario120x120;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 24);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(143, 98);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(220, 24);
            this.txtContrasena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Persona Responsable";
            // 
            // txtPersonaResponsable
            // 
            this.txtPersonaResponsable.Location = new System.Drawing.Point(15, 168);
            this.txtPersonaResponsable.Name = "txtPersonaResponsable";
            this.txtPersonaResponsable.Size = new System.Drawing.Size(348, 24);
            this.txtPersonaResponsable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rol Funcional";
            // 
            // rbtnAdministrador
            // 
            this.rbtnAdministrador.AutoSize = true;
            this.rbtnAdministrador.Location = new System.Drawing.Point(39, 240);
            this.rbtnAdministrador.Name = "rbtnAdministrador";
            this.rbtnAdministrador.Size = new System.Drawing.Size(117, 22);
            this.rbtnAdministrador.TabIndex = 8;
            this.rbtnAdministrador.Text = "Administrador";
            this.rbtnAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbtnOperador
            // 
            this.rbtnOperador.AutoSize = true;
            this.rbtnOperador.Checked = true;
            this.rbtnOperador.Location = new System.Drawing.Point(224, 240);
            this.rbtnOperador.Name = "rbtnOperador";
            this.rbtnOperador.Size = new System.Drawing.Size(89, 22);
            this.rbtnOperador.TabIndex = 9;
            this.rbtnOperador.TabStop = true;
            this.rbtnOperador.Text = "Operador";
            this.rbtnOperador.UseVisualStyleBackColor = true;
            // 
            // btnGrabarDatos
            // 
            this.btnGrabarDatos.AutoSize = true;
            this.btnGrabarDatos.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Confirmar32x32;
            this.btnGrabarDatos.Location = new System.Drawing.Point(95, 296);
            this.btnGrabarDatos.Name = "btnGrabarDatos";
            this.btnGrabarDatos.Size = new System.Drawing.Size(140, 45);
            this.btnGrabarDatos.TabIndex = 10;
            this.btnGrabarDatos.Text = "Grabar Datos";
            this.btnGrabarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabarDatos.UseVisualStyleBackColor = true;
            // 
            // IUFormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 377);
            this.Controls.Add(this.btnGrabarDatos);
            this.Controls.Add(this.rbtnOperador);
            this.Controls.Add(this.rbtnAdministrador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersonaResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IUFormularioUsuario";
            this.Text = "IUFormularioUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonaResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnAdministrador;
        private System.Windows.Forms.RadioButton rbtnOperador;
        private System.Windows.Forms.Button btnGrabarDatos;
    }
}
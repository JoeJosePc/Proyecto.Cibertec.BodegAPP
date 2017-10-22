namespace InterfacesDeUsuarioBodegAPP
{
    partial class IULogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IULogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(218, 24);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(15, 137);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(218, 24);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyDown);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Location = new System.Drawing.Point(12, 168);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(127, 18);
            this.lblMensajeError.TabIndex = 7;
            this.lblMensajeError.Text = "Datos Incorrectos";
            this.lblMensajeError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.LoginSeguridad210x210;
            this.pictureBox1.Location = new System.Drawing.Point(239, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 210);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(124, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Image = global::InterfacesDeUsuarioBodegAPP.Properties.Resources.Confirmar32x32;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(15, 195);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 40);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "© BodegAPP v.0.1";
            // 
            // IULogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(454, 249);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IULogin";
            this.Text = "BodegAPP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}
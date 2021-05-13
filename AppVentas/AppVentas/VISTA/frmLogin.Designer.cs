
namespace AppVentas
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btbIniciarSecion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(84, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(289, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(289, 20);
            this.txtPass.TabIndex = 1;
            // 
            // btbIniciarSecion
            // 
            this.btbIniciarSecion.Location = new System.Drawing.Point(84, 130);
            this.btbIniciarSecion.Name = "btbIniciarSecion";
            this.btbIniciarSecion.Size = new System.Drawing.Size(289, 23);
            this.btbIniciarSecion.TabIndex = 2;
            this.btbIniciarSecion.Text = "Iniciar Sesión";
            this.btbIniciarSecion.UseVisualStyleBackColor = true;
            this.btbIniciarSecion.Click += new System.EventHandler(this.btbIniciarSecion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN";
            // 
            // btnRegistroUsuario
            // 
            this.btnRegistroUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUsuario.ForeColor = System.Drawing.Color.Blue;
            this.btnRegistroUsuario.Location = new System.Drawing.Point(84, 159);
            this.btnRegistroUsuario.Name = "btnRegistroUsuario";
            this.btnRegistroUsuario.Size = new System.Drawing.Size(289, 23);
            this.btnRegistroUsuario.TabIndex = 3;
            this.btnRegistroUsuario.Text = "¿No tienes una cuenta?Regístrate";
            this.btnRegistroUsuario.UseVisualStyleBackColor = true;
            this.btnRegistroUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 208);
            this.Controls.Add(this.btnRegistroUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbIniciarSecion);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btbIniciarSecion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistroUsuario;
    }
}


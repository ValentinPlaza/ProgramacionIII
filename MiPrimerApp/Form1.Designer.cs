
namespace MiPrimerApp
{
    partial class Ventana
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
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.Lb_Edad = new System.Windows.Forms.Label();
            this.TB_Edad = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.Lb_Direccion = new System.Windows.Forms.Label();
            this.Lb_Resultado = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.TB_Apellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Apellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Apellido.Location = new System.Drawing.Point(36, 13);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(65, 20);
            this.Lb_Apellido.TabIndex = 104;
            this.Lb_Apellido.Text = "Apellido";
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Resultado.Location = new System.Drawing.Point(31, 293);
            this.TB_Resultado.MaxLength = 150;
            this.TB_Resultado.Multiline = true;
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(260, 59);
            this.TB_Resultado.TabIndex = 5;
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Nombre.Location = new System.Drawing.Point(36, 70);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(65, 20);
            this.Lb_Nombre.TabIndex = 103;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Nombre.Location = new System.Drawing.Point(31, 93);
            this.TB_Nombre.MaxLength = 30;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(184, 20);
            this.TB_Nombre.TabIndex = 2;
            // 
            // Lb_Edad
            // 
            this.Lb_Edad.AutoSize = true;
            this.Lb_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Edad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Edad.Location = new System.Drawing.Point(36, 124);
            this.Lb_Edad.Name = "Lb_Edad";
            this.Lb_Edad.Size = new System.Drawing.Size(47, 20);
            this.Lb_Edad.TabIndex = 102;
            this.Lb_Edad.Text = "Edad";
            // 
            // TB_Edad
            // 
            this.TB_Edad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Edad.Location = new System.Drawing.Point(31, 147);
            this.TB_Edad.MaxLength = 30;
            this.TB_Edad.Name = "TB_Edad";
            this.TB_Edad.Size = new System.Drawing.Size(78, 20);
            this.TB_Edad.TabIndex = 3;
            this.TB_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Edad_KeyPress);
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Direccion.Location = new System.Drawing.Point(31, 205);
            this.TB_Direccion.MaxLength = 60;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(184, 20);
            this.TB_Direccion.TabIndex = 4;
            // 
            // Lb_Direccion
            // 
            this.Lb_Direccion.AutoSize = true;
            this.Lb_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Direccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Direccion.Location = new System.Drawing.Point(36, 182);
            this.Lb_Direccion.Name = "Lb_Direccion";
            this.Lb_Direccion.Size = new System.Drawing.Size(75, 20);
            this.Lb_Direccion.TabIndex = 101;
            this.Lb_Direccion.Text = "Direccion";
            // 
            // Lb_Resultado
            // 
            this.Lb_Resultado.AutoSize = true;
            this.Lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Resultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Resultado.Location = new System.Drawing.Point(36, 270);
            this.Lb_Resultado.Name = "Lb_Resultado";
            this.Lb_Resultado.Size = new System.Drawing.Size(82, 20);
            this.Lb_Resultado.TabIndex = 100;
            this.Lb_Resultado.Text = "Resultado";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Location = new System.Drawing.Point(169, 395);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Aceptar.Location = new System.Drawing.Point(56, 395);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // TB_Apellido
            // 
            this.TB_Apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_Apellido.Location = new System.Drawing.Point(31, 36);
            this.TB_Apellido.MaxLength = 30;
            this.TB_Apellido.Name = "TB_Apellido";
            this.TB_Apellido.Size = new System.Drawing.Size(184, 20);
            this.TB_Apellido.TabIndex = 1;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.TB_Apellido);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.Lb_Resultado);
            this.Controls.Add(this.Lb_Direccion);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.TB_Edad);
            this.Controls.Add(this.Lb_Edad);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.Lb_Apellido);
            this.Controls.Add(this.TB_Resultado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label Lb_Edad;
        private System.Windows.Forms.TextBox TB_Edad;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.Label Lb_Direccion;
        private System.Windows.Forms.Label Lb_Resultado;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox TB_Apellido;
        public System.Windows.Forms.TextBox TB_Resultado;
    }
}


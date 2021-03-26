
namespace AppWinFormII
{
    partial class Form1
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
            System.Windows.Forms.RadioButton RB_Otro;
            this.GB = new System.Windows.Forms.GroupBox();
            this.RB_Mujer = new System.Windows.Forms.RadioButton();
            this.RB_Hombre = new System.Windows.Forms.RadioButton();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Lb_Programador = new System.Windows.Forms.Label();
            this.CB_Programador = new System.Windows.Forms.CheckBox();
            this.Lb_Salida = new System.Windows.Forms.Label();
            this.TB_Salida = new System.Windows.Forms.TextBox();
            RB_Otro = new System.Windows.Forms.RadioButton();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_Otro
            // 
            RB_Otro.AutoSize = true;
            RB_Otro.Checked = true;
            RB_Otro.Location = new System.Drawing.Point(296, 22);
            RB_Otro.Name = "RB_Otro";
            RB_Otro.Size = new System.Drawing.Size(54, 21);
            RB_Otro.TabIndex = 2;
            RB_Otro.TabStop = true;
            RB_Otro.Text = "Otro";
            RB_Otro.UseVisualStyleBackColor = true;
            // 
            // GB
            // 
            this.GB.Controls.Add(RB_Otro);
            this.GB.Controls.Add(this.RB_Mujer);
            this.GB.Controls.Add(this.RB_Hombre);
            this.GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB.ForeColor = System.Drawing.Color.Black;
            this.GB.Location = new System.Drawing.Point(15, 89);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(420, 56);
            this.GB.TabIndex = 0;
            this.GB.TabStop = false;
            this.GB.Text = "Sexo";
            this.GB.UseCompatibleTextRendering = true;
            // 
            // RB_Mujer
            // 
            this.RB_Mujer.AutoSize = true;
            this.RB_Mujer.Location = new System.Drawing.Point(183, 22);
            this.RB_Mujer.Name = "RB_Mujer";
            this.RB_Mujer.Size = new System.Drawing.Size(61, 21);
            this.RB_Mujer.TabIndex = 1;
            this.RB_Mujer.Text = "Mujer";
            this.RB_Mujer.UseVisualStyleBackColor = true;
            // 
            // RB_Hombre
            // 
            this.RB_Hombre.AutoSize = true;
            this.RB_Hombre.Location = new System.Drawing.Point(51, 22);
            this.RB_Hombre.Name = "RB_Hombre";
            this.RB_Hombre.Size = new System.Drawing.Size(76, 21);
            this.RB_Hombre.TabIndex = 0;
            this.RB_Hombre.Text = "Hombre";
            this.RB_Hombre.UseVisualStyleBackColor = true;
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.Location = new System.Drawing.Point(12, 18);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(58, 17);
            this.Lb_Nombre.TabIndex = 1;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(76, 17);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(338, 20);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Nombre_Validating);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.Location = new System.Drawing.Point(439, 15);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Lb_Programador
            // 
            this.Lb_Programador.AutoSize = true;
            this.Lb_Programador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Programador.Location = new System.Drawing.Point(12, 55);
            this.Lb_Programador.Name = "Lb_Programador";
            this.Lb_Programador.Size = new System.Drawing.Size(91, 17);
            this.Lb_Programador.TabIndex = 4;
            this.Lb_Programador.Text = "Programador";
            // 
            // CB_Programador
            // 
            this.CB_Programador.AutoSize = true;
            this.CB_Programador.Checked = true;
            this.CB_Programador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Programador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Programador.Location = new System.Drawing.Point(106, 58);
            this.CB_Programador.Name = "CB_Programador";
            this.CB_Programador.Size = new System.Drawing.Size(15, 14);
            this.CB_Programador.TabIndex = 5;
            this.CB_Programador.UseVisualStyleBackColor = true;
            // 
            // Lb_Salida
            // 
            this.Lb_Salida.AutoSize = true;
            this.Lb_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Salida.Location = new System.Drawing.Point(12, 160);
            this.Lb_Salida.Name = "Lb_Salida";
            this.Lb_Salida.Size = new System.Drawing.Size(47, 17);
            this.Lb_Salida.TabIndex = 6;
            this.Lb_Salida.Text = "Salida";
            // 
            // TB_Salida
            // 
            this.TB_Salida.Location = new System.Drawing.Point(15, 180);
            this.TB_Salida.Multiline = true;
            this.TB_Salida.Name = "TB_Salida";
            this.TB_Salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Salida.Size = new System.Drawing.Size(409, 138);
            this.TB_Salida.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 329);
            this.Controls.Add(this.TB_Salida);
            this.Controls.Add(this.Lb_Salida);
            this.Controls.Add(this.CB_Programador);
            this.Controls.Add(this.Lb_Programador);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.GB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.RadioButton RB_Mujer;
        private System.Windows.Forms.RadioButton RB_Hombre;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Label Lb_Programador;
        private System.Windows.Forms.CheckBox CB_Programador;
        private System.Windows.Forms.Label Lb_Salida;
        private System.Windows.Forms.TextBox TB_Salida;
    }
}


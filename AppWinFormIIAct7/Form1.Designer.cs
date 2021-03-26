
namespace AppWinFormIIAct7
{
    partial class Practica_7
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
            this.Btn_Negrita = new System.Windows.Forms.Button();
            this.Btn_Subrayado = new System.Windows.Forms.Button();
            this.Btn_Cursiva = new System.Windows.Forms.Button();
            this.Btn_Centrado = new System.Windows.Forms.Button();
            this.Lb_TamFuente = new System.Windows.Forms.Label();
            this.TB_TamFuente = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Abrir = new System.Windows.Forms.Button();
            this.RTB_Texto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_Negrita
            // 
            this.Btn_Negrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Negrita.Location = new System.Drawing.Point(12, 12);
            this.Btn_Negrita.Name = "Btn_Negrita";
            this.Btn_Negrita.Size = new System.Drawing.Size(75, 23);
            this.Btn_Negrita.TabIndex = 0;
            this.Btn_Negrita.Text = "Negrita";
            this.Btn_Negrita.UseVisualStyleBackColor = true;
            this.Btn_Negrita.Click += new System.EventHandler(this.Btn_Negrita_Click);
            // 
            // Btn_Subrayado
            // 
            this.Btn_Subrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Subrayado.Location = new System.Drawing.Point(138, 12);
            this.Btn_Subrayado.Name = "Btn_Subrayado";
            this.Btn_Subrayado.Size = new System.Drawing.Size(75, 23);
            this.Btn_Subrayado.TabIndex = 1;
            this.Btn_Subrayado.Text = "Subrayado";
            this.Btn_Subrayado.UseVisualStyleBackColor = true;
            this.Btn_Subrayado.Click += new System.EventHandler(this.Btn_Subrayado_Click);
            // 
            // Btn_Cursiva
            // 
            this.Btn_Cursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Cursiva.Location = new System.Drawing.Point(268, 12);
            this.Btn_Cursiva.Name = "Btn_Cursiva";
            this.Btn_Cursiva.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cursiva.TabIndex = 2;
            this.Btn_Cursiva.Text = "Cursiva";
            this.Btn_Cursiva.UseVisualStyleBackColor = true;
            // 
            // Btn_Centrado
            // 
            this.Btn_Centrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Centrado.Enabled = false;
            this.Btn_Centrado.Location = new System.Drawing.Point(397, 12);
            this.Btn_Centrado.Name = "Btn_Centrado";
            this.Btn_Centrado.Size = new System.Drawing.Size(75, 23);
            this.Btn_Centrado.TabIndex = 3;
            this.Btn_Centrado.Text = "Centrado";
            this.Btn_Centrado.UseVisualStyleBackColor = true;
            // 
            // Lb_TamFuente
            // 
            this.Lb_TamFuente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_TamFuente.AutoSize = true;
            this.Lb_TamFuente.Location = new System.Drawing.Point(146, 58);
            this.Lb_TamFuente.Name = "Lb_TamFuente";
            this.Lb_TamFuente.Size = new System.Drawing.Size(82, 13);
            this.Lb_TamFuente.TabIndex = 4;
            this.Lb_TamFuente.Text = "Tamaño Fuente";
            // 
            // TB_TamFuente
            // 
            this.TB_TamFuente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_TamFuente.Location = new System.Drawing.Point(245, 55);
            this.TB_TamFuente.MaxLength = 2;
            this.TB_TamFuente.Name = "TB_TamFuente";
            this.TB_TamFuente.Size = new System.Drawing.Size(65, 20);
            this.TB_TamFuente.TabIndex = 5;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Guardar.Location = new System.Drawing.Point(138, 270);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 7;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Abrir.Location = new System.Drawing.Point(268, 270);
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Abrir.TabIndex = 8;
            this.Btn_Abrir.Text = "Abrir";
            this.Btn_Abrir.UseVisualStyleBackColor = true;
            // 
            // RTB_Texto
            // 
            this.RTB_Texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Texto.Location = new System.Drawing.Point(12, 95);
            this.RTB_Texto.Name = "RTB_Texto";
            this.RTB_Texto.Size = new System.Drawing.Size(460, 154);
            this.RTB_Texto.TabIndex = 9;
            this.RTB_Texto.Text = "";
            // 
            // Practica_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 303);
            this.Controls.Add(this.RTB_Texto);
            this.Controls.Add(this.Btn_Abrir);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.TB_TamFuente);
            this.Controls.Add(this.Lb_TamFuente);
            this.Controls.Add(this.Btn_Centrado);
            this.Controls.Add(this.Btn_Cursiva);
            this.Controls.Add(this.Btn_Subrayado);
            this.Controls.Add(this.Btn_Negrita);
            this.MinimumSize = new System.Drawing.Size(502, 342);
            this.Name = "Practica_7";
            this.Text = "WinFormII Practica 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Negrita;
        private System.Windows.Forms.Button Btn_Subrayado;
        private System.Windows.Forms.Button Btn_Cursiva;
        private System.Windows.Forms.Button Btn_Centrado;
        private System.Windows.Forms.Label Lb_TamFuente;
        private System.Windows.Forms.TextBox TB_TamFuente;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Abrir;
        private System.Windows.Forms.RichTextBox RTB_Texto;
    }
}


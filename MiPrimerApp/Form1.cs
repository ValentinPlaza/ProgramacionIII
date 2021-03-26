using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        //private void Ventana_Click(object sender, EventArgs e)
        //{
        //    MouseEventArgs click = (MouseEventArgs) e;

        //    if (click.Button == MouseButtons.Left)
        //        MessageBox.Show("Presiono el boton izquierdo", "Lee a continuacion");
        //    else if (click.Button == MouseButtons.Right)
        //        MessageBox.Show("Presiono el boton derecho", "Lee a continuacion");
        //    else if (click.Button == MouseButtons.Middle)
        //        MessageBox.Show("Presiono el boton del medio", "Lee a continuacion");
        //}

        private void TB_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >59 ) && e.KeyChar != 8){
                e.Handled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //if (TB_Apellido.Text == "")
            //    TB_Apellido.BackColor = Color.Red;
            //else
            //    TB_Apellido.BackColor = System.Drawing.SystemColors.Window;
            bool confirmar = false;

            if (TB_Apellido.Text == "")
            {
                TB_Apellido.BackColor = Color.Red;
                confirmar = false;
            }
            else {
                TB_Apellido.BackColor = System.Drawing.SystemColors.Window;
                confirmar = true;
            }

            if (TB_Nombre.Text == "")
            {
                TB_Nombre.BackColor = Color.Red;
                confirmar = false;
            }
            else {
                TB_Nombre.BackColor = System.Drawing.SystemColors.Window;
                confirmar = true;
            }

            if (TB_Edad.BackColor == Color.Red)
                confirmar = false;

            else
            {
                TB_Edad.BackColor = System.Drawing.SystemColors.Window;
                confirmar = true;
            }
            
            if (TB_Direccion.Text == "")
            {
                TB_Direccion.BackColor = Color.Red;
                confirmar = false;
            }
            else
            {
                TB_Direccion.BackColor = System.Drawing.SystemColors.Window;
            }

            if (TB_Edad.Text == "")
            {
                TB_Edad.BackColor = Color.Red;
                confirmar = false;
            }
            else
            {
                TB_Direccion.BackColor = System.Drawing.SystemColors.Window;
            }

            if (confirmar)
            {
                TB_Resultado.Text = TB_Nombre.Text + Environment.NewLine + TB_Apellido.Text + Environment.NewLine + TB_Edad.Text + Environment.NewLine + TB_Direccion.Text;
                TB_Resultado.Show();
            }
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

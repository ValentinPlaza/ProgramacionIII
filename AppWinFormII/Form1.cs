using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinFormII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarOK()
        {
            //habilita el boton siempre y cuando el TextBox tenga datos.
            Btn_Ok.Enabled = (TB_Nombre.BackColor != Color.Red);
        }

        private void TB_Nombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender; // ??????

            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;

            ValidarOK();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //desabilito el boton ok
            Btn_Ok.Enabled = false;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Botón esta Habilitado
            //es porque paso el Evento Validating del Nombre.
            String salida; //Declaro una variable para armar la salida.
            salida = "Nombe: " + TB_Nombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(CB_Programador.Checked ?
            "Programador" : "No es Programador") + "\r\n";
            salida += "Sexo: " + (string)(RB_Hombre.Checked ? "Hombre" :
            RB_Mujer.Checked ? "Mujer" : "Otro") + "\r\n";

            //Vuelco la salida al TextB
            TB_Salida.Text = salida;
        }
    }
}

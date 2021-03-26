using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinFormIIAct7
{
    public partial class Practica_7 : Form
    {
        public Practica_7()
        {
            InitializeComponent();
        }

        private void Btn_Negrita_Click(object sender, EventArgs e)
        {
            Font viejaFuente; //Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente; //Declaro una variable Class Font para la Fuente Nueva.
                              //Asigno a viejaFuente el tipo de fuente seleccionado.
                              //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
                              //del Control RichTextBox.
            viejaFuente = RTB_Texto.SelectionFont;
            if (viejaFuente.Bold) //Pregunto si ya es Negrita.
                                  //Si ya Tenia Negrita, establece nuevaFuente sin Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Bold);
            else
                //Si no Tenia Negrita, establece nuevaFuente con Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Bold);

            //Establezco la nuevaFuente a la Selección.
            RTB_Texto.SelectionFont = nuevaFuente;
            //Realizo un foco para posicionarme en el Control. porque ??
            RTB_Texto.Focus();
        }

        private void Btn_Subrayado_Click(object sender, EventArgs e)
        {
            Font viejaFuente; //Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente; //Declaro una variable Class Font para la Fuente Nueva.
                              //Asigno a viejaFuente el tipo de fuente seleccionado.
                              //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
                              //del Control RichTextBox.
            viejaFuente = RTB_Texto.SelectionFont;
            if (viejaFuente.Underline) //Pregunto si ya es Subrayado.
                                       //Si ya Tenia Subrayado, establece nuevaFuente sin Subrayado.
                                       // ~ ????????? Destructor ?
            nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Underline);
            else
                //Si no Tenia Subrayado, establece nuevaFuente con Subrayado.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Underline);
            //Establezco la nuevaFuente a la Selección.
            RTB_Texto.SelectionFont = nuevaFuente;
            //Realizo un foco para posicionarme en el Control.
            RTB_Texto.Focus();
        }
        /// me quede en el paso 6
    }
}

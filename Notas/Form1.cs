using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            float promedio, n1, n2, n3, n4, n5;
            n1 = float.Parse(txtnota1.Text);
            n2 = float.Parse(txtnota2.Text);
            n3 = float.Parse(txtnota3.Text);
            n4 = float.Parse(txtnota4.Text);
            n5 = float.Parse(txtnota5.Text);


            promedio = (n1 + n2 + n3 + n4 + n5) / 5;
            txtpromedio.Text = promedio.ToString();

            if (promedio <= 1) 
            {
                lblstatus.Text = "Reprueba la materia sin lograr realizar proceso de recuperacion";
            }
            else if (promedio <= 2.9)
            {
                lblstatus.Text = "Reprueba la materia y puede hacer la habilitacion.";
            }
            else if (promedio <= 3 - 9)
            {
                lblstatus.Text = "Aprueba la materia con plan de mejora";
            }
            else if (promedio <= 4.5)
            {
                lblstatus.Text = "Buen rendimiento";
            }
            else if (promedio<=4.9)
            {
                lblstatus.Text = "Excelente";
            }
            else
            {
                lblstatus.Text = "Graduado con honores";
            } 

        }
    }
}

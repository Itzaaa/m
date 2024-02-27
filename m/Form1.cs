using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Verificar si los valores ingresados son válidos
            if (!double.TryParse(metroTextBox1.Text, out double baseNumber) ||
                !int.TryParse(metroTextBox2.Text, out int exponent))
            {
                // Mostrar un mensaje de error si los valores no son válidos
                MessageBox.Show("Por favor, ingrese un número válido para la base y un número entero válido para el exponente.");
                return;
            }

            // Calcular el resultado de la potencia
            double result = Math.Pow(baseNumber, exponent);

            // Mostrar el resultado en el metroLabel1
            metroLabel1.Text = result.ToString();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

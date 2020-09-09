using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EersteFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToonNaam_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Hallo " + txtNaam.Text + "\nKlopt dit?", "Dit is een welkomstmelding!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Fijn om te horen", ":)");
            } else if(result == DialogResult.No) {
                MessageBox.Show("Je vult toch zelf je naam in?", ":(");
            }

            /* Huiswerk
            
            Maak een loginscherm met username/wachtwoord en een button
            Gebruik een dafault username/ww wat gedefinieerd staat in de code
            en koppel terug naar de gebruiker of hij de juiste inloggegevens heeft gebruikt of een fout heeft gemaakt

            */
        }
    }
}

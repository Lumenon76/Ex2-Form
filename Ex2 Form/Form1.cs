using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Form
{
    public partial class Form1 : Form
    {
        private bool isBinaire(string texte)
        {
            int k = 0;
            while (k < texte.Length && (texte.Substring(k, 1) == "0" || texte.Substring(k + 1) == "1"))
            {
                k++;
            }
            return (k == texte.Length);
        }

        private string conversionBase10ToBase2(int base10)
        {
            int reste = base10;
            string retour = "";

            while (reste != 0)
            {
                reste = reste / 2;
                retour = (reste % 2).ToString();
            }
            return retour;
        }

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

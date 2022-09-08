using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDes
{
    public partial class Form1 : Form
    {
        private Controleur controleur;
        public Form1()
        {
            InitializeComponent();
            controleur = new Controleur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBrasser_Click(object sender, EventArgs e)
        {
            string[] resultat = controleur.Tirage();
            string type = resultat[0];
            int valeur = Convert.ToInt32(resultat[1]);
            int total = Convert.ToInt32(resultat[2]);

            labelType.Text = "Type de dé : " + type;
            labelResultat.Text = "Résultat : " + valeur.ToString();
            labelTotal.Text = "Total : " + total.ToString();
        }
    }
}

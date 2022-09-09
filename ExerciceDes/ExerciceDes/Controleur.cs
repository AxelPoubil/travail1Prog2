using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDes
{
    public class Controleur
    {
        private int total;
        private List<Des> listeDes;
        Random rand;
        public Controleur()
        {
            listeDes = new List<Des>()
            {
                new DeOrdinaire(),
                new DePipe()
            };

            rand = new Random();
        }

        public int Total { get => total; set => total = value; }
        public List<Des> ListeDes { get => listeDes; set => listeDes = value; }

        public string[] Tirage ()
        {
            int indexType = rand.Next(listeDes.Count);

            Des deChoisi = listeDes[indexType];

            string type = deChoisi.Type;
            int valeur = deChoisi.Brasser();

            Total += valeur;
            string[] resultats = { type, valeur.ToString(), Total.ToString() };

            return resultats;
        }
    }
}

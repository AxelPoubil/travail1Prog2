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
        public Controleur()
        {
            listeDes = new List<Des>()
            {
                new DeOrdinaire(),
                new DePipe()
            };
        }

        public int Total { get => total; set => total = value; }
        public List<Des> ListeDes { get => listeDes; set => listeDes = value; }

        public string[] Tirage ()
        {
            Random choixDe = new Random();
            int indexType = choixDe.Next(listeDes.Count);

            string type = listeDes[indexType].Type;
            int valeur = listeDes[indexType].Brasser();

            Total += valeur;
            string[] resultats = { type, valeur.ToString(), Total.ToString() };

            return resultats;
        }
    }
}

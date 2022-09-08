using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDes
{
    class DeOrdinaire : Des
    {
        public DeOrdinaire() : base("Ordinaire")
        {
            
        }

        public override int Brasser()
        {
            Random random = new Random();
            int[] valeurs = { 1, 2, 3, 4, 5, 6};
            int index = random.Next(valeurs.Length);

            return valeurs[index];
        }
    }
}

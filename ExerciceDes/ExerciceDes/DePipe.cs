using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDes
{
    class DePipe : Des
    {
        public DePipe() : base("Pipe")
        {
        }

        public override int Brasser()
        {
            Random random = new Random();
            int[] valeurs = { 1, 2, 3, 4, 4, 5, 5, 6, 6 };
            int index = random.Next(valeurs.Length);
            
            return valeurs[index];
        }
    }
}

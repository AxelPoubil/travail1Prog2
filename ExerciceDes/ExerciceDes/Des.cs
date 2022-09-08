using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDes
{
    public abstract class Des
    {
        private string type;

        protected Des(string type)
        {
            this.type = type;
        }
        public string Type { get => type; set => type = value; }

        public abstract int Brasser();
        
    }
}

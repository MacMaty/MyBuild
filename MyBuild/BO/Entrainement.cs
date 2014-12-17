using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild.BO
{
    class Entrainement
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public int Recompense { get; set; }
        public Type LeType { get; set; }
        private List<Exercice> lesExos = null;
        
        public Entrainement()
        {
            lesExos = new List<Exercice>();
            
        }

       
    }
}

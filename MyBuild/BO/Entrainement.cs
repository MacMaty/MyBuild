using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild.BO
{
    public class Entrainement
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public int Recompense { get; set; }
        public int NbTour { get; set; }
        public TypeEntrainement LeType { get; set; }
        public List<Tour> lesTours = null;
        
        public Entrainement()
        {
            lesTours = new List<Tour>();
            
        }

       
    }
}

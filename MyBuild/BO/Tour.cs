using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild.BO
{
    public class Tour
    {
        public int numeroTour { get; set; }
        public List<Exercice> lesExercices {get;set;}
        public Tour()
        {
            lesExercices = new List<Exercice>();
        }
    }
}

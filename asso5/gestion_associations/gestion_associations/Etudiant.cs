using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_associations
{
    class Etudiant : Individu
    {
        public int Id { get; set;  }
        public string LyceeOrigine { get; set; }
        public string SpecialiteBac { get; set; }
        public DateTime AnneeObtentionBac { get; set; }
        public DateTime DateEntreeBts { get; set; }
        public DateTime DateSortieBts { get; set; }
        public DateTime PromoBts { get; set;  }
        public string SpecialiteBts { get; set;  }
        public DateTime DateObtentionBts { get; set; }
        public string Role { get; set;  }
        public string Rang  { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_associations
{
     class professionnel : Individu
    {
        public int IdProfessionnel  { get; set; }
        public string SecteurActivite { get; set; }
        public DateTime DateEntreeMondePro { get; set; }
        public string Nom { get; set;  }
        public string Prenom { get; set;  }
        public int Num { get; set;  }
        public string Mail { get; set;  }





    }
}

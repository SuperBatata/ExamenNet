using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Abonne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public DateTime DateCreation { get; set; }

         
        public Status Status { get; set; }
        


        public virtual IList<PretLivre> PretLivres { get; set; }



    }
}

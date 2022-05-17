using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Livre
    {
        
        public int LivreId { get; set; }
        [Required]
        public string Isbn { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbrExemplaire { get; set; }
            
        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }


        public virtual IList<PretLivre> PretLivres { get; set; }


        public virtual Categorie Categorie { get; set; }
        public int CategorieFK { get; set; }


    }
}

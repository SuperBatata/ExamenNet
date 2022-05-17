using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Categorie
    {
        [Key]
        public int Code { get; set; }
        public string Libelle { get; set; }


        public virtual IList<Livre> Livres { get; set; }
    }
}

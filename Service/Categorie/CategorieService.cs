using PS.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Categorie
{
    public class CategorieService : ServicePattern.Service<Domain.Categorie>, ICategorieService
    {
        public CategorieService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}

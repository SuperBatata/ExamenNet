using PS.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.PretLivre
{
    public class PretLivreService : ServicePattern.Service<Domain.PretLivre>, IPretLivreService
    {
        public PretLivreService(IUnitOfWork utwk) : base(utwk)
        {
        }


        public IList<Domain.PretLivre> GetMostBorrowedBooks()
        {
            return (IList<Domain.PretLivre>)GetMany(p => p.DateDebut == null);
        }

        
        public IList<Domain.PretLivre> GetBorrowedBooksbydate(DateTime startDate, DateTime endDate)
        {
            return GetMany(p => p.DateFin == null && p.DateDebut >= startDate && p.DateDebut <= endDate).ToList();
        }

       
    }
}

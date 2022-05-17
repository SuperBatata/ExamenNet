using System;
using System.Collections.Generic;
using System.Text;
using ServicePattern;

namespace Service.PretLivre
{
    public interface IPretLivreService : IService<Domain.PretLivre>
    {

        IList<Domain.PretLivre> GetMostBorrowedBooks();

        IList<Domain.PretLivre> GetBorrowedBooksbydate(DateTime startDate, DateTime endDate);


    }
}

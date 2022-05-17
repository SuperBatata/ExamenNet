using PS.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Abonne
{
    public class AbonneService : ServicePattern.Service<Domain.Abonne>, IAbonneService
    {
        public AbonneService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}

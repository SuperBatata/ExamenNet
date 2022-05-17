using PS.Data.Infrastructure;


namespace Service.Livre
{
    public class LivreService : ServicePattern.Service<Domain.Livre>, ILivreService
    {
        public LivreService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}

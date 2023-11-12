using System.Threading.Tasks;

namespace Parcial3_RuaRuizJhonattan.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;

        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync() {

            await _context.Database.EnsureCreatedAsync();

            await PopulateTicketsAsync();
        }

        #region Private Methos

        private async Task PopulateTicketsAsync()
        {

            if (!_context.Tickets.Any())
            {
                for(int i = 0; i < 1000; i++)
                {
                   _=_context.Tickets.Add(new Entities.Tickets
                    {
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null,
                       
                    });
                }

                await _context.SaveChangesAsync();


            }

    }

    #endregion

}
}

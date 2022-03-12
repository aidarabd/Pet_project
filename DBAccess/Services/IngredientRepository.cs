using System.Linq;
using System.Net.NetworkInformation;
using DBAccess.Models;
using DBAccess.Services.Base;

namespace DBAccess.Services
{
    public class IngredientRepository : BaseRepository<Ingredient>
    {
        public IngredientRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
using System.Linq;
using System.Net.NetworkInformation;
using DBAccess.Models;
using DBAccess.Services.Base;

namespace DBAccess.Services
{
    public class RecipeRepository : BaseRepository<Recipe>
    {
        private AppDbContext _dbContext;

        public RecipeRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
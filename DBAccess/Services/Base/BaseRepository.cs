using System.Linq;
using DBAccess.Models;
using DBAccess.Models.Base;

namespace DBAccess.Services.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private AppDbContext _dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public T Get(int id)
        {
            var res = _dbContext.Set<T>().FirstOrDefault(x=>x.Id == id);
            return res;
        }
    }

    public interface IBaseRepository<T> where T : class
    {
        public void Add(T entity);
        public T Get(int id);
    }
}
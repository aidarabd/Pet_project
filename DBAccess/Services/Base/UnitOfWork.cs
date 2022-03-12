using System;
using DBAccess.Models;

namespace DBAccess.Services.Base
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext DbContext;
        private IngredientRepository IngredientRepository;
        private RecipeRepository RecipeRepository;
        private bool disposed = false;
        public UnitOfWork(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IngredientRepository Ingredients
        {
            get
            {
                if (IngredientRepository == null) 
                    return new IngredientRepository(DbContext);
                return IngredientRepository;
            }
        }

        public RecipeRepository Recipes
        {
            get
            {
                if (RecipeRepository == null)
                    return new RecipeRepository(DbContext);
                return RecipeRepository;
            }
        }

        public int Save()
        {
           return DbContext.SaveChanges();

        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
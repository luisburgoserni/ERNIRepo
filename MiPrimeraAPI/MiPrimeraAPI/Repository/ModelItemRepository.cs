using MiPrimeraAPI.DataAccess;
using MiPrimeraAPI.Models;

namespace MiPrimeraAPI.Repository
{
    public class ModelItemRepository : IModelItemRepository
    {
        private readonly IBBDDContext _context;

        public ModelItemRepository(IBBDDContext context)
        {
            _context = context;
        }

        public void UpdateModelItem(ModelItem model)
        {
            _context.ModelItem.Update(model);
            _context.SaveChanges();
        }

        public async void DeleteModelItem(int id)
        {
            var entity = await Get(id);
            _context.ModelItem.Remove(entity);
            _context.SaveChanges();
        }

        public async Task AddModelItem(ModelItem model)
        {
            await _context.ModelItem.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task <ModelItem> Get(int id)
        {
            return await _context.ModelItem.FindAsync(id);
        }
    }
}

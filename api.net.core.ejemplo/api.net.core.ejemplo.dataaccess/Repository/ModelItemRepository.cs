using api.net.core.ejemplo.dataaccess.contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.dataaccess.contracts.Repository
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

        public async Task AddModelItem(ModelItem model)
        {
            await _context.ModelItem.AddAsync(model);
            await _context.SaveChangesAsync();

        }

        public async Task<ModelItem> Get(int id)
        {
            return await _context.ModelItem.FindAsync(id);          
        }

        public ModelItem GetWhere(int id)
        {
            return  _context.ModelItem.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);

            _context.ModelItem.Remove(entity);
        }

    }
}

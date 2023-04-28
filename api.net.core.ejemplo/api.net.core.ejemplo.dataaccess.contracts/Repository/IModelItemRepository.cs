using api.net.core.ejemplo.dataaccess.contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.dataaccess.contracts.Repository
{
    public interface IModelItemRepository
    {
        Task AddModelItem(ModelItem model);
        Task<ModelItem> Get(int id);
        ModelItem GetWhere(int id);
        void UpdateModelItem(ModelItem model);
        Task Delete(int id);
    }
}

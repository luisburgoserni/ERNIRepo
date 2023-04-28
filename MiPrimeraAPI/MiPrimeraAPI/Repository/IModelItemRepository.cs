using MiPrimeraAPI.Models;

namespace MiPrimeraAPI.Repository
{
    public interface IModelItemRepository
    {
        Task AddModelItem(ModelItem model);

        Task<ModelItem> Get(int id);

        void UpdateModelItem(ModelItem model);

        void DeleteModelItem(int id);
    }
}

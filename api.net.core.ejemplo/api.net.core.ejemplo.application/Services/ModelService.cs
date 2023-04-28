using api.net.core.ejemplo.application.contracts.Mappers;
using api.net.core.ejemplo.application.contracts.Services;
using api.net.core.ejemplo.bussiness.Models;
using api.net.core.ejemplo.dataaccess.contracts.Mapper;
using api.net.core.ejemplo.dataaccess.contracts.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.application.Services
{
    public class ModelService : IModelService
    {

        private readonly IModelItemRepository _modelItemRepository;

        public ModelService(IModelItemRepository modelItemRepository)
        {
            _modelItemRepository = modelItemRepository;
        }

        public async Task<Model> GetModels(int id)
        {
            var entity = await _modelItemRepository.Get(id);

            return ModelModelMapper.Map(entity);
        }

        public async Task AddModel(Model model)
        {
             _modelItemRepository.AddModelItem(ModelEntityMapper.Map(model));

        }

        public async Task UpdateModel(Model model)
        {
            _modelItemRepository.UpdateModelItem(ModelEntityMapper.Map(model));

        }

        public async Task DeleteModel(int id)
        {
            _modelItemRepository.Delete(id);

        }

    }
}

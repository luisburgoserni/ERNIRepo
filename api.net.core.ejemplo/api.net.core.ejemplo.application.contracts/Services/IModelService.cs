using api.net.core.ejemplo.bussiness.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.application.contracts.Services
{
    public interface IModelService
    {
        Task<Model> GetModels(int id);
        Task AddModel(Model model);
        Task UpdateModel(Model model);
        Task DeleteModel(int id);
    }
}

using BaseRepository;
using pracitices.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseService
{
    public abstract class BaseService<TModel> where TModel : MongoBaseModel
    {
        public IBaseRepository<TModel> BaseRepository { get; set; }
  

        public BaseService(IBaseRepository<TModel> baseRepository)
        {
            BaseRepository = baseRepository;
        }



        public virtual TModel GetModel(string id)
        {
            return this.BaseRepository.GetById(id);
        }


        public virtual List<TModel> GetModelList()
        {
            return this.BaseRepository.GetList();
        }


        public virtual TModel AddModel(TModel model)
        {
            return this.BaseRepository.Create(model);
        }


        public virtual bool UpdateModel(string id, TModel model)
        {
            this.BaseRepository.Update(id, model);
            return true;
        }


        public virtual void DeleteModel(string id)
        {
            this.BaseRepository.Delete(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaseRepository
{
    public interface IBaseRepository<TModel>
    {
        List<TModel> GetList();
        TModel GetById(string id);
        TModel Create(TModel model);
        void Update(string id, TModel model);
        void Delete(TModel model);
        void Delete(string id);
    }
}

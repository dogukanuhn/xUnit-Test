
using DataRepository;
using pracitices.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices
{
    public class DataService : IDataService
    {
        public DataService(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        public IDataRepository DataRepository { get; }

        public Data GetData(string id)
        {
            return DataRepository.GetById(id);
        }

        public Data Insert(Data model)
        {
            return DataRepository.Create(model);
        }
    }
}

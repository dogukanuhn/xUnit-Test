using BaseRepository;
using pracitices.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public class DataRepository : BaseRepository<Data>,IDataRepository
    {
        public DataRepository(IBookstoreDatabaseSettings settings) : base(settings)
        {
        }

       
    }
}

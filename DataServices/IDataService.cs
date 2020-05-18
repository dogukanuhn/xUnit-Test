using pracitices.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices
{
    public interface IDataService
    {
        Data GetData(string id);

        Data Insert(Data model);
    }
}

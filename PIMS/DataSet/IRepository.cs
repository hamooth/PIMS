using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS.DataSet
{
    public interface IRepositary : IDisposable //multiple inheridance
    {
        IEnumerable<T> GetAll<T>() where T : class;

        void AddData<T>(T Entry) where T : class;

        void UpdateData<T>(T Entry) where T : class;

        void DeleteData<T>(T Entry) where T : class;
    }
}

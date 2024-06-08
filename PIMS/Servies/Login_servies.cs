using PIMS.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS.Servies
{
    public class Loginservices
    {
        Repository _Repo;
        public Loginservices()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Table_add_new_user> ListAll()
        {
            return _Repo.GetAll<Table_add_new_user>().ToList();
        }

        

     
    }
}

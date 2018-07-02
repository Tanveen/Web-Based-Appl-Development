using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.DataLayer
{
    public interface IDataAccess
    {
           object GetSingleAnswer(string sql, List<DbParameter> plist);
         int InsertUpdateDelete(string sql, List<DbParameter> plist);
          DataTable GetManyRowsCols(string sql, List<DbParameter> plist);

}
}

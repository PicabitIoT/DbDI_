using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDI
{
    public interface IDbCon
    {
        // Otros métodos necesarios...
        //string SelectString(string query);
        public bool SelectDataTable(string query, out DataTable dataTable);
    }
}

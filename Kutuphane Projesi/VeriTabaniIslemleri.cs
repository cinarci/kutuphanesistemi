using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Projesi
{
    internal class VeriTabaniIslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;

        public SqlConnection baglan()
        {
            SqlConnection sqlConnection = new SqlConnection(baglantiCumlesi);
            sqlConnection.Open(); 
            return sqlConnection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start
{
    public class baglan
    {
        public static SqlConnection baglanti = new SqlConnection(@"data source=MSI;initial catalog=start;integrated security=true");
        public static void CheckConnection(SqlConnection baglanti)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {

            }

        }
    }
}

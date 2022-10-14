using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACADLAYER1
{
    public class SQLBAGLANTISI

    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=DBTESTKATMAN;Integrated Security=True");

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlygara
{
    public class ClassConnection
    {
        private static String connectionString = @"Data Source=DESKTOP-TR5J0OJ;Initial Catalog=quanlygara;Integrated Security=True";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }
}

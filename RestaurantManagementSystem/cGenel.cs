using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class cGenel
    {

        /* public SqlConnection baglan()
         {
             SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=LargerRestaurantSystem; User Id=sa; Password =1234; "); //Trusted_Connection=true;
             baglanti.Open();
             SqlConnection.ClearAllPools();
             SqlConnection.ClearPool(baglanti);
             return (baglanti);
         }*/

        public string conString = ("Server=LTS\\SQLSERVER; Database=LargerRestaurantSystem;Trusted_Connection=True");

        public static int _EmployeeId;
        public static int _TaskId;

        public static string _ButtonValue;
        public static string _ButtonName;
    }
}

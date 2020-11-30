using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();

        private int _ProductTypeNo;
        private string _CategoryName;
        private string _Explanation;

        public int ProductTypeNo
        {
            get
            {
                return _ProductTypeNo;
            }

            set
            {
                _ProductTypeNo = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return _CategoryName;
            }

            set
            {
                _CategoryName = value;
            }
        }

        public string Explanation
        {
            get
            {
                return _Explanation;
            }

            set
            {
                _Explanation = value;
            }
        }

        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select ProductName,Price,Products.ID from Categories inner join Products on Categories.ID = Products.CategoryID where Products.CategoryID=@CategoryID", conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            comm.Parameters.Add("@CategoryID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["ProductName"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Price"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Id"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
    }
}

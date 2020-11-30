using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    class cSiparis
    {
        cGenel gnl = new cGenel();
        private int _ID;
        private int _TheAdditionId;
        private int _ProductId;
        private int _Quantity;
        private int _TableId;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public int TheAdditionId
        {
            get
            {
                return _TheAdditionId;
            }

            set
            {
                _TheAdditionId = value;
            }
        }

        public int ProductId
        {
            get
            {
                return _ProductId;
            }

            set
            {
                _ProductId = value;
            }
        }



        public int TableId
        {
            get
            {
                return _TableId;
            }

            set
            {
                _TableId = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _Quantity;
            }

            set
            {
                _Quantity = value;
            }
        }

        public void getByOrder(ListView lv, int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select ProductName,Price,Sales.ID,ProductID,Sales.Quantity from Sales inner join Products on Sales.ProductID = Products.ID where TheAdditionID=@AdisyonId",con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ProductName"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Quantity"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ProductID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Price"]) * Convert.ToDecimal(dr["Quantity"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Sales(TheAdditionId,ProductId,Quantity,TableId) values(@TheAdditionNo,@ProductId,@Quantity, @TableId", con);
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@TheAdditionNo", SqlDbType.Int).Value = Bilgiler.TheAdditionId;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Bilgiler.ProductId;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Bilgiler.Quantity;
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = Bilgiler.TableId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RestaurantManagementSystem
{
    class cMasalar
    {
        private int _ID;
        private int _Capacity;
        private int _ServiceType;
        private int _State;
        private int _Confirmation;
        private int _TableNo;

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

        public int Capacity
        {
            get
            {
                return _Capacity;
            }

            set
            {
                _Capacity = value;
            }
        }

        public int ServiceType
        {
            get
            {
                return _ServiceType;
            }

            set
            {
                _ServiceType = value;
            }
        }

        public int State
        {
            get
            {
                return _State;
            }

            set
            {
                _State = value;
            }
        }

        public int Confirmation
        {
            get
            {
                return _Confirmation;
            }

            set
            {
                _Confirmation = value;
            }
        }

        public int TableNo
        {
            get
            {
                return _TableNo;
            }

            set
            {
                _TableNo = value;
            }
        }

        cGenel gnl = new cGenel();
        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Date,TableID from TheAdditions right join tables on TheAdditions.tableID = tables.ID where tables.State = @State and theAdditions.State=0", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@State", SqlDbType.Int).Value = state;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Date"]).ToString();
                }
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;

            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }

        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select State from tables where ID =@TableId and State=@State", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@State", SqlDbType.Int).Value = state;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
            return result;
        }

        public void setChangeTableState(string ButtonName,int durum)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update tables set State=@State where ID=@tableNo", con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButtonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@State", SqlDbType.Int).Value = State;
            cmd.Parameters.Add("@TableNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}

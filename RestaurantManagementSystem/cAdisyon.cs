using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RestaurantManagementSystem
{
    class cAdisyon
    {
        cGenel gnl = new cGenel();

        private int _ID;
        private int _ServiceTypeNo;
        private decimal _Price;
        private DateTime _Date;
        private int _EmployeeId;
        private int _State;
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



        public decimal Price
        {
            get
            {
                return _Price;
            }

            set
            {
                _Price = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public int EmployeeId
        {
            get
            {
                return _EmployeeId;
            }

            set
            {
                _EmployeeId = value;
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

        public int ServiceTypeNo
        {
            get
            {
                return _ServiceTypeNo;
            }

            set
            {
                _ServiceTypeNo = value;
            }
        }

        public int getAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 from TheAdditions where TableID=@MasaId order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return MasaId;
        }

        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into TheAdditions(ServiceTypeNo,Date,EmployeeId,State) values(@ServiceTypeNo,@Date,@EmployeeId,@TableId,@State", con);
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ServiceTypeNo", SqlDbType.Int).Value = Bilgiler.ServiceTypeNo;

                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = Bilgiler.Date;
                cmd.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = Bilgiler.EmployeeId;
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = Bilgiler.TableId;
                cmd.Parameters.Add("@State", SqlDbType.Bit).Value = 0;
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

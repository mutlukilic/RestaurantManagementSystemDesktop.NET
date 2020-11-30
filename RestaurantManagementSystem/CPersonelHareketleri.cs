using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RestaurantManagementSystem
{
    class CPersonelHareketleri
    {
        cGenel gnl = new cGenel();
        private int _ID;
        private int _EmployeeId;
        private string _Operation;
        private DateTime _Date;
        private bool _State;

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

        public string Operation
        {
            get
            {
                return _Operation;
            }

            set
            {
                _Operation = value;
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

        public bool State
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

        public bool PersonelActionSave(CPersonelHareketleri ph)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into ActivityOfEmployees(EmployeeID,Operation,Date)Values(@EmployeeId,@Operation,@Date)", con);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = ph._EmployeeId;
                cmd.Parameters.Add("@Operation", SqlDbType.VarChar).Value = ph._Operation;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = ph._Date;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
    }
}

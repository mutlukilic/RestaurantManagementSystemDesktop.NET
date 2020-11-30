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
    class cPersoneller
    {
        cGenel gnl = new cGenel();
        private int _EmployeeId;
        private int _TaskId;
        private string _EmployeeName;
        private string _EmployeeSurname;
        private string _EmployeePassword;
        private string _EmployeeUserName;
        private bool _EmployeeState;

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

        public int TaskId
        {
            get
            {
                return _TaskId;
            }

            set
            {
                _TaskId = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return _EmployeeName;
            }

            set
            {
                _EmployeeName = value;
            }
        }

        public string EmployeeSurname
        {
            get
            {
                return _EmployeeSurname;
            }

            set
            {
                _EmployeeSurname = value;
            }
        }

        public string EmployeePassword
        {
            get
            {
                return _EmployeePassword;
            }

            set
            {
                _EmployeePassword = value;
            }
        }

        public string EmployeeUserName
        {
            get
            {
                return _EmployeeUserName;
            }

            set
            {
                _EmployeeUserName = value;
            }
        }

        public bool EmployeeState
        {
            get
            {
                return _EmployeeState;
            }

            set
            {
                _EmployeeState = value;
            }
        }


        public bool personelEntryControl(string password, int userId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Employees where ID=@Id and Password=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = userId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
        public void personelGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Employees ", con);



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p.EmployeeId = Convert.ToInt32(dr["ID"]);
                p.TaskId = Convert.ToInt32(dr["TaskID"]);
                p.EmployeeName = Convert.ToString(dr["Name"]);
                p.EmployeePassword = Convert.ToString(dr["Password"]);
                p.EmployeeSurname = Convert.ToString(dr["Surname"]);
                p.EmployeeState = Convert.ToBoolean(dr["State"]);
                p.EmployeeUserName = Convert.ToString(dr["UserName"]);
                cb.Items.Add(p);

            }
            dr.Close();
            con.Close();

        }

        public override string ToString()
        {
            return EmployeeName+" "+EmployeeSurname;
        }
    }
}

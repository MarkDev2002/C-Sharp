using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace DAO
{
    public class StaffDAO : DataConection
    {
        public StaffDAO() { }

        private static StaffDAO _instance;

        public static StaffDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new StaffDAO();
                return _instance;
            }
            set { _instance = value; }
        }


        public List<StaffDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from Staff where status = 'ACT'";

            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<StaffDTO> list = new List<StaffDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new StaffDTO(dr));
            }

            return list;
        }
		public List<StaffDTO> GetAllAccountOfStaff(string staffID)
		{
			DataTable _dt = new DataTable();

			string query = "select * from Staff where StaffId='"+staffID+"' and status = 'ACT';";

			_dt = DataProvider.Instance.ExecuteQuery(query);

			List<StaffDTO> list = new List<StaffDTO>();

			foreach (DataRow dr in _dt.Rows)
			{
				list.Add(new StaffDTO(dr));
			}

			return list;
		}

		public bool UpdateAddAccount(StaffDTO staffDTO)
        {
            Moketnoi();
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "UPDATE Staff SET UserID = @userid WHERE StaffID = @staffid;";
            cmd.Connection = conn;
			cmd.Parameters.Add("@staffid", MySqlDbType.VarString).Value = staffDTO.IdStaff;
			cmd.Parameters.Add("@userid", MySqlDbType.VarString).Value = staffDTO.UserId;
			int kq = cmd.ExecuteNonQuery();
			return kq > 0;
		}
        public bool Insert(StaffDTO staffDTO)
        {


            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Staff(StaffID, UserID, FirstName, LastName, YearOfBirth, Gender, Phone, Address, Salary, Img, Status) Values(@idStaff,@userId,@firstName,@lastName,@year,@gender,@phone,@address,@salary,@img, 'ACT')";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idStaff", MySqlDbType.VarString).Value = staffDTO.IdStaff;
            cmd.Parameters.Add("@userId", MySqlDbType.VarString).Value = staffDTO.UserId;
            cmd.Parameters.Add("@firstName", MySqlDbType.VarString).Value = staffDTO.FirstName;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarString).Value = staffDTO.LastName;
            cmd.Parameters.Add("@year", MySqlDbType.Int64).Value = staffDTO.Year;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = staffDTO.Gender;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = staffDTO.Phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = staffDTO.Address;
            cmd.Parameters.Add("@salary", MySqlDbType.VarString).Value = staffDTO.Salary;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = staffDTO.Image;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
        }


        public bool Update(StaffDTO staffDTO)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Staff set UserID = @userId, FirstName = @firstName, LastName = @lastName, YearOfBirth = @year, Gender = @gender, Phone = @phone, Address = @address, Salary = @salary, Img = @img where StaffID = @idStaff";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idStaff", MySqlDbType.VarString).Value = staffDTO.IdStaff;
            cmd.Parameters.Add("@userId", MySqlDbType.VarString).Value = staffDTO.UserId;
            cmd.Parameters.Add("@firstName", MySqlDbType.VarString).Value = staffDTO.FirstName;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarString).Value = staffDTO.LastName;
            cmd.Parameters.Add("@year", MySqlDbType.Int64).Value = staffDTO.Year;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = staffDTO.Gender;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = staffDTO.Phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = staffDTO.Address;
            cmd.Parameters.Add("@salary", MySqlDbType.VarString).Value = staffDTO.Salary;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = staffDTO.Image;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
        }

        public bool UpdateProfile(StaffDTO staffDTO)
        {
            string query = string.Format("update Staff set FirstName = '{1}', LastName = '{2}', Phone = '{3}', Address = '{4}' where StaffID = '{0}'", staffDTO.IdStaff, staffDTO.FirstName, staffDTO.LastName, staffDTO.Phone, staffDTO.Address);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            Console.WriteLine(staffDTO.IdStaff + " " + staffDTO.FirstName + " " + staffDTO.LastName + " " + staffDTO.Phone + " " + staffDTO.Address + " " + staffDTO.Salary + " " + staffDTO.Image);

            try
            {
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string idStaff)
        {
            DataTable _dt = new DataTable();
			string query = "select * from Staff where StaffID='"+idStaff+"'";
			_dt = DataProvider.Instance.ExecuteQuery(query);
			string query_2 = string.Format("update Staff set status = 'DEL' where StaffID = '{0}'", idStaff);
			string query_3 = string.Format("Update Account SET Enable = '0' WHERE UserID = '{0}'", _dt.Rows[0]["UserID"].ToString());
			DataProvider.Instance.ExecuteNonQuery(query_3);
			try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query_2);
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<StaffDTO> FindName(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select * from Staff where LastName like N'%{0}%' or FirstName like N'%{0}%' and status = 'ACT'", name);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<StaffDTO> list = new List<StaffDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new StaffDTO(dr));
            }

            return list;

        }
    }
}

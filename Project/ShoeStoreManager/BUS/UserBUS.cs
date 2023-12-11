using DAO;
using DTO;


namespace BUS
{
    public class UserBUS
    {
		private static UserBUS _instance;

		public static UserBUS Instance
		{
			get
			{
				if (_instance == null) _instance = new UserBUS();
				return _instance;
			}
			set { _instance = value; }
		}
		UserDAO userDAO = new UserDAO();
        public int checkRoleID(string userid)
        {
            string roleid;
            int check_flag;
            roleid=userDAO.getRoleIDFromAccountByUserID(userid);
            if(roleid == "ROL001")
            {
                check_flag = 1;
            }
            else if (roleid == "ROL002")
            {
                check_flag = 2;
            }
            else
            {
                check_flag = 3;
            }
            return check_flag;
        }
        public string LoginBUS(UserDTO us)
        {



            if (us.Username1 == "" || us.Password1 == "")
            {
                return "thong bao";
            }


            if (userDAO.LoginDAO(us) != null)

                return "thanh cong";

            else
                return "that bai";


        }
    }
}

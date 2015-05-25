using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Login
    {
        private DaoLayer.userDAO userDAO;

        public Login(){

            userDAO= new DaoLayer.userDAO();
        }
        public bool isLogin(String username, String password)
        {


            DAO.user user = userDAO.getUser(username);

            if (user != null & user.password.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}

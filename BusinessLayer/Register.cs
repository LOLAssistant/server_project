using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Register
    {

        private DaoLayer.userDAO userDAO;

        public Register(){

         userDAO = new DaoLayer.userDAO();

        }

        public bool RegisterUser(DAO.user user)
        {
            return userDAO.insertUser(user);
        }
    }
}

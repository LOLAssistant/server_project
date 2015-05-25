using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BindAccount
    {
        private DaoLayer.lolDAO lolDAO;

        public BindAccount()
        {
            lolDAO = new DaoLayer.lolDAO();
      
        }

        public bool BindLOLAccount(DAO.lol lol)
        {
            return lolDAO.insertLOL(lol);
        }
    }
}

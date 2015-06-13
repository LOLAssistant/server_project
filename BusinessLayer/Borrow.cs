using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Borrow
    {

        public bool BorrowAccount(String qq)
        {
            

            DaoLayer.lolDAO lolDAO=new DaoLayer.lolDAO();
            DAO.lol lol = lolDAO.getlolbyqq(qq);

            if (lol.state != 0)
            {
                return false;
            }
            lolDAO.changeState(lol);

            return true ;

        }
    }
}

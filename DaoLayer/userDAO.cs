using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaoLayer
{
    public class userDAO
    {
        private DAO.DataClasses1DataContext db = new DAO.DataClasses1DataContext();
        

        //对DB中插入USER
        public bool insertUser(DAO.user _user)
        {
            //Console.WriteLine("insertUser");
            db.user.InsertOnSubmit(_user);

            try
            {
                db.SubmitChanges();
            }
            catch(Exception ee)
            {
                Console.Write(ee);
                return false;
            }

            //Console.WriteLine("insertUser success");
            return true;
        }

        //根据username查询DB中的USER
        public DAO.user getUser(String username)
        {
            IQueryable<DAO.user> one = from c in db.user
                                   where c.username == username
                                   select c;
            //这里只会有唯一的一个返回结果
            return one.First();
        }
    }
}
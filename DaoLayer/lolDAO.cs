using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaoLayer
{
    public class lolDAO
    {
        private DAO.DataClasses1DataContext db = new DAO.DataClasses1DataContext();

        //对DB中插入lol user
        public bool insertLOL(DAO.lol _lol)
        {
            db.lol.InsertOnSubmit(_lol);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception ee)
            {
                Console.Write(ee);
                return false;
            }

            Console.WriteLine("insertLOL success");
            return true;
        }

        //根据username查询DB中的LOL账号
        public List<DAO.lol> getLolList(String username)
        {
            IQueryable<DAO.lol> result = from c in db.lol
                                     where c.username == username
                                     select c;

            List<DAO.lol> lols = new List<DAO.lol>();
            foreach (var detail in result)
            {
                lols.Add(detail);
            }
            //这里只会有唯一的一个返回结果
            return lols;
        }
    }
}
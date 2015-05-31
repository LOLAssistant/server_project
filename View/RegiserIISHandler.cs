using System;
using System.Web;

namespace View
{
    public class RegiserIISHandler : IHttpHandler
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        private BusinessLayer.Register register;


        public RegiserIISHandler()
        {
            register = new BusinessLayer.Register();
        }
        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //在此写入您的处理程序实现

            DAO.user user=new DAO.user();

            user.username = context.Request.Form["username"];
            user.password = context.Request.Form["password"];
            user.nickname = context.Request.Form["nickname"];
            user.ID =context.Request.Form["id"];
            user.levelpoint = 1;
            user.phone = context.Request.Form["phone"];
            user.e_mail = context.Request.Form["email"];

            if (register.RegisterUser(user))
            {
                context.Response.Write("true");
            }
            else
            {
                context.Response.Write("false");
            }
        }

        #endregion
    }
}

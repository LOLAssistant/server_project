using System;
using System.Web;

namespace View
{
    public class LoginIISHandler : IHttpHandler
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members
        private BusinessLayer.Login login;

        public LoginIISHandler()
        {
            login = new BusinessLayer.Login();
        }
        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            
            //String username = context.Request.Form["username"];
            //String password = context.Request.Form["password"];
            context.Response.ContentType = "text/plain";



           //LOLWebservice.CheckUserServiceSoapClient checkuserService = new LOLWebservice.CheckUserServiceSoapClient();
            //context.Response.Write(checkuserService.matching("hanchunyu","hehehehe"));

            String username = "han1993";
            String password = "123456";
            if (login.isLogin(username, password))
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

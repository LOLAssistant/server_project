using System;
using System.Web;

namespace View
{
    public class BindAccountIISHandler : IHttpHandler
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        private BusinessLayer.BindAccount BindAccount;

        public BindAccountIISHandler()
        {
            BindAccount = new BusinessLayer.BindAccount();
        }

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //在此写入您的处理程序实现。

            DAO.lol lol = new DAO.lol();
            lol.lolusername = context.Request.Form["qq"];
            lol.lolpassword = context.Request.Form["password"];
            lol.username = context.Request.Form["username"];
            localhost.CheckUserService service = new localhost.CheckUserService();
            localhost.IDSoapHeader IDHeader = new localhost.IDSoapHeader();
            IDHeader.UserName = "wangchao";
            IDHeader.PassWord = "wangchao";
            service.IDSoapHeaderValue = IDHeader;

            //LOLWebservice.CheckUserServiceSoapClient checkuserService = new LOLWebservice.CheckUserServiceSoapClient();
            if (service.matching(lol.lolusername, lol.lolpassword))
            {
                if (BindAccount.BindLOLAccount(lol))
                {
                    context.Response.Write("true");
                }
                else
                {
                    context.Response.Write("false");
                }
            }
            else
            {
                context.Response.Write("false");
            }

        }

        #endregion
    }
}

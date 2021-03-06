﻿using System;
using System.Web;

namespace View
{
    public class BorrowAccountIISHandler : IHttpHandler
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //在此写入您的处理程序实现。

            String username="";
            String qq="";

            BusinessLayer.Borrow borrow = new BusinessLayer.Borrow();

            if (borrow.BorrowAccount(qq))
            {

                localhost.CheckUserService service = new localhost.CheckUserService();
                localhost.IDSoapHeader header = new localhost.IDSoapHeader();
                header.UserName = "wangchao";
                header.PassWord = "wangchao";
                service.IDSoapHeaderValue = header;
                service.extractCode_record("提取码", "用户名");
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

using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.BLL.Abstract
{
    public interface IMailBLL
    {
        bool SendMail(Request request);
    }
}

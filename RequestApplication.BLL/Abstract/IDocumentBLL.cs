using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.BLL.Abstract
{
    public interface IDocumentBLL
    {
        byte[] Download(string file);
        byte[] Report(int requestId);
    }
}

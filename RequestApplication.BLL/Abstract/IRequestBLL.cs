using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.BLL.Abstract
{
    public interface IRequestBLL
    {
        IQueryable<Request> GetAllRequests();
        Request GetRequest(int id);
        void AddRequest(Request request);
        void UpdateRequest(Request Request);
        void DeleteRequest(int id);
    }
}

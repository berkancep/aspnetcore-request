using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Abstract
{
    public interface IRequestRepository
    {
        IQueryable<Request> GetAll();
        Request Get(int id);
        void Add(Request request);
        void Update(Request request);
        void Delete(int id);
        void Save();
    }
}

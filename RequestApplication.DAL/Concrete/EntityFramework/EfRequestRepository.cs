using Microsoft.EntityFrameworkCore;
using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Concrete.EntityFramework
{
    public class EfRequestRepository : IRequestRepository
    {
        private readonly RequestContext _context;

        public EfRequestRepository(RequestContext context)
        {
            _context = context;
        }

        public void Add(Request request)
        {
            _context.Add(request);
            Save();
        }

        public void Delete(int id)
        {
            var entity = Get(id);

            if (entity != null)
            {
                _context.Remove(entity);
                Save();
            }
        }

        public Request Get(int id)
        {
            return _context.Requests.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Request> GetAll()
        {
            return _context.Requests.Include(a => a.User);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Request request)
        {
            var entity = Get(request.Id);

            if (entity != null)
            {
                entity.ReplyDate = request.ReplyDate;
                entity.IsPositive = request.IsPositive;
                entity.Reply = request.Reply;

                Save();
            }
        }
    }
}

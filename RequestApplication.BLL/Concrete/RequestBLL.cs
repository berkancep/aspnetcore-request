using RequestApplication.BLL.Abstract;
using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.BLL.Concrete
{
    public class RequestBLL : IRequestBLL
    {
        private readonly IRequestRepository _requestRepository;

        public RequestBLL(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public void AddRequest(Request request)
        {
            _requestRepository.Add(request);
        }

        public void DeleteRequest(int id)
        {
            _requestRepository.Delete(id);
        }

        public IQueryable<Request> GetAllRequests()
        {
            return _requestRepository.GetAll();
        }

        public Request GetRequest(int id)
        {
            return _requestRepository.Get(id);
        }

        public void UpdateRequest(Request request)
        {
            _requestRepository.Update(request);
        }
    }
}

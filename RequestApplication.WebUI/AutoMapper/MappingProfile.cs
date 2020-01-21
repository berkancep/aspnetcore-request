using AutoMapper;
using RequestApplication.Entitiy;
using RequestApplication.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<RegisterViewModel, User>();
            CreateMap<LoginViewModel, User>();

            CreateMap<Request, RequestListViewModel>();
            CreateMap<RequestCreateViewModel, Request>();


            CreateMap<Request, ResponseListViewModel>().ForMember(a => a.FullName, from => from.MapFrom(b => b.User.FullName));
            CreateMap<ResponseAnswerViewModel, Request>();
            CreateMap<Request, ResponseAnswerViewModel>();

    
        }
    }
}

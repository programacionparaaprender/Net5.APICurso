using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            definicion4();
        }

        private void definicion4()
        {
            CreateMap<CreditCard, CustomerDto>()
                .ReverseMap();

            CreateMap<Customer, CustomerDto>()
                .IncludeMembers(x => x.CreditCard)
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.GetFullName()))
                .ReverseMap();
        }

        private void definicion3()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.GetFullName()))
                //.ForMember(dest => dest.CCNumber, opt => opt.MapFrom(x => x.CreditCard.Number))
                //.ForMember(dest => dest.CCValidDate, opt => opt.MapFrom(x => x.CreditCard.ValidDate))
                .ReverseMap();
        }

        private void definicion1()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }

        private void definicion2()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }

    }
}

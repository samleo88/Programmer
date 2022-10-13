using AutoMapper;
using StoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StoreWebApi.DTO_s
{
    public class AutoMapperConfiguration
    {
                public static void Configure()
        {

            Mapper.Initialize
                
              (cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>()
                   .ForMember(x => x.CustomerOrder, o => o.Ignore())
                   //.ForMember(x => x.Nombre, o => o.MapFrom(s => s.FirstName))
                   .ReverseMap();

                cfg.CreateMap<CustomerOrder, CustomerOrderDTO>()
                   .ForMember(x => x.OrderDetail, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Employee, EmployeeDTO>()
                   .ReverseMap();

                cfg.CreateMap<OrderDetail, OrderDetailDTO>()
                   .ReverseMap();

                cfg.CreateMap<OrderStatus, OrderStatusDTO>()
                   .ForMember(x => x.CustomerOrder, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Product, ProductDTO>()
                   .ForMember(x => x.OrderDetail, o => o.Ignore())
                   .ReverseMap();
            });
        }

    }
}

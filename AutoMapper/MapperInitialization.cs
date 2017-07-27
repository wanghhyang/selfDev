using AutoMapper;
using AutoMapperDTO;
using AutoMapperEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperCreater
{
    public class MapperInitialization
    {
        public static void InitMapper()
        {
            Mapper.Initialize(a =>
            {
                a.CreateMap<AddressDto, Address>();
                a.CreateMap<BookDto, Book>().ForMember(bok => bok.Publisher/*(变量)*/,
                      (map) => map.MapFrom(dto => new Publisher() { Name = dto.Publisher/*(DTO的变量)*/}));

                a.CreateMap<BookStoreDto, BookStore>();
            });
            
        }
    }
}

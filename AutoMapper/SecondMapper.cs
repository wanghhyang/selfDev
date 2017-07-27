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
    public class SecondMapper
    {
        public void MapBookStore()
        {

            BookStoreDto dto = new BookStoreDto
            {
                Name = "My Store",
                Address = new AddressDto
                {
                    City = "Beijing"
                },
                Books = new List<BookDto>
                                {
                                    new BookDto { Title = "RESTful Web Service" },
                                    new BookDto { Title = "Ruby for Rails" },
                                }
            };
            BookStore bookStore = Mapper.Map<BookStoreDto, BookStore>(dto);
        }
    }
}

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
  public  class FirstMapper
    {
        public void MapperTest()
        {
            AddressDto dto = new AddressDto
            {
                Country = "China",
                City = "Beijing",
                Street = "Dongzhimen Street",
                PostCode = "100001"
            };
            Address address = Mapper.Map<AddressDto, Address>(dto);
        }
    }
}

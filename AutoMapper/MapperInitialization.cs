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
            Mapper.Initialize(a => a.CreateMap<AddressDto, Address>());
        }
    }
}

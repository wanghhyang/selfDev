using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDTO
{
      public class BookStoreDto
    {
        public string Name { get; set; }
        public List<BookDto> Books { get; set; }
        public AddressDto Address { get; set; }
    }
}

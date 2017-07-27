using MapperCreater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化映射关系
            MapperInitialization.InitMapper();

            FirstMapper mapper = new FirstMapper();
            mapper.MapperTest();

            SecondMapper secondMapper = new SecondMapper();
            secondMapper.MapBookStore();
        }
    }
}

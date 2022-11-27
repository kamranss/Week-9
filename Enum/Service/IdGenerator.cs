using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Service
{
    internal abstract class IdGenerator
    {
        public   int IdForEachUser { get;  }

        public IdGenerator()
        {
            IdForEachUser++;
           
        }
    }
}

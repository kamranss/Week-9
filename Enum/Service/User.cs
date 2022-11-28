using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Service
{
    internal class User:IdGenerator
    {
        
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Positions Position { get; set; }

        public User()
        {
            
            Id = IdForEachUser;
        }
        
    }
}

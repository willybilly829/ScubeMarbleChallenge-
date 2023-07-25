using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleChallenge
{

    class Marble
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Double Weight { get; set; }

        public override string ToString()
        {
            return "{ Id: " + Id + ", color: " + Color + ", weight: " + Weight + ", name: " + Name + "}";
        }
    }
}

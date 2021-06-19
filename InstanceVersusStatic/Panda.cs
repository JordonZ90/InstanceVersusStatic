using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVersusStatic
{
    public class Panda
    {
        public string Name; // Instance field
        public static int Population; // Static field
        // Population pertains to all instances of Panda

        public Panda(string name) // Consturctor
        {
            Name = name; // Assign the instance field
            Population += 1; // Increment the static field
        }
    }
}

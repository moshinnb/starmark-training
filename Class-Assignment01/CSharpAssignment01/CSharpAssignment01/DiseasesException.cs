using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment01
{
    class DiseasesException:Exception
    {
        public DiseasesException() { }
        public DiseasesException(string message):base(message) { }

    }
}

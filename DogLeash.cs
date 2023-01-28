using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercise_2
{
    public class DogLeash : Product
    {
        int LengthInches { get; set; }
        string Material { get; set; }

    public DogLeash()
        {
            Material = string.Empty;
        }
    }
}

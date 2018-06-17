using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.ASPNETCore.Middleware.Service
{
    public interface IMyScopedService
    {
        int MyProperty { get; set; }
    }

    public class MyScopedService : IMyScopedService
    {
        public int MyProperty { get; set; }
    }
}

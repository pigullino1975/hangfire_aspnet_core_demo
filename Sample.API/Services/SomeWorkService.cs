using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Services
{
    public interface ISomeWorkService
    {
        void DoSomeWork();
    }

    public class SomeWorkService : ISomeWorkService
    {
        public void DoSomeWork()
        {
            Console.WriteLine(string.Format("Shut up I am running - {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        }
    }
}

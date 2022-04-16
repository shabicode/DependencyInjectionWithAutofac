using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionWithAutofac.Services;

namespace DependencyInjectionWithAutofac
{
    internal class SMSService : IMobileService
    {
        public void Send()
        {
            Console.WriteLine("SMS service executing.");
        }
    }
}

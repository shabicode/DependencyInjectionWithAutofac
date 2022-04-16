using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionWithAutofac.Services;

namespace DependencyInjectionWithAutofac
{
    internal class EmailService : IMailService
    {
        public void Send()
        {
            Console.WriteLine("Email service Executing.");
        }
    }
}

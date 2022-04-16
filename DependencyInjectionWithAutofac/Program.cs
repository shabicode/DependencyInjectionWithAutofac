using Autofac;
using DependencyInjectionWithAutofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithAutofac
{
    internal class Program
    {

        /*https://autofac.readthedocs.io/en/latest/register/registration.html*/
        /*You register components with Autofac by creating a ContainerBuilder and informing the builder which components expose which services.*/
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SMSService>().As<IMobileService>();
            builder.RegisterType<EmailService>().As<IMailService>();
            var container = builder.Build();

            container.Resolve<IMobileService>().Send();
            container.Resolve<IMailService>().Send();
            Console.ReadLine();

        }
    }
}

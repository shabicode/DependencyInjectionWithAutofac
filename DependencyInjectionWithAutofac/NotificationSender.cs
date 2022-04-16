using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionWithAutofac.Services;

namespace DependencyInjectionWithAutofac
{
    public class NotificationSender
    {
        public IMailService mailService = null;
        public IMobileService mobileService = null;

        //injection through constructor  
        public NotificationSender(IMobileService mobileService)
        {
            this.mobileService = mobileService;
        }

        //Injection through property  
        public IMailService setImailService
        {
            set { mailService = value; }
        }

        public void SendNotification()
        {
            mailService.Send();
            mobileService.Send();
        }
    }
}

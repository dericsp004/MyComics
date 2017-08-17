using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyComics.Services
{
    public interface IMailService
    {
        void sendMail(string to, string from, string subject, string message);
    }
}

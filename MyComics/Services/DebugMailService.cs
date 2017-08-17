using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyComics.Services
{
    public class DebugMailService : IMailService
    {
        public void sendMail(string to, string from, string subject, string message)
        {
            Debug.Write($"SendingMail To: {to}, From: {from}, Subject: {subject}, Message: {message}");
        }
    }
}

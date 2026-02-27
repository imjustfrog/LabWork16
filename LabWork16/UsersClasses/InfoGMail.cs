using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.UsersClasses;

namespace LabWork15.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("mikhailisakov08@gmail.com", "Исаков Михаил");
            EmailPassword = "**** **** **** ****"; //Пароль убрал тк репозиторий открытый
            Port = 587;
        }
    }
}

using _03.Telephony.IO;
using _03.Telephony.IO.Interfaces;
using _03.Telephony.Models;
using _03.Telephony.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            string[] phonenNumbers = reader
               .ReadLine()
               .Split(" ");

            string[] urls = reader
            .ReadLine()
            .Split(" ");

            ICallable callable = default;
            foreach (var phoneNumber in phonenNumbers)
            {
                if (phoneNumber.Length == 10)
                {
                    callable = new Smartphone();
                }
                else if (phoneNumber.Length == 7)
                {
                    callable = new Stationary();
                }

                try
                {
                    writer.WriteLine(callable.Call(phoneNumber));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable = new Smartphone();
            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLine(browsable.SurfingInInternet(url));
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
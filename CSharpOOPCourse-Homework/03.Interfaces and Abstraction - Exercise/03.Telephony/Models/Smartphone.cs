using _03.Telephony.IO;
using _03.Telephony.IO.Interfaces;
using _03.Telephony.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        private const string NotOnlyDigitsException = "Invalid number!";
        private const string DigitException = "Invalid URL!";

        public string Call(string phoneNumber)
        {
            DoesItContainOnlyDigits(phoneNumber);
            return $"Calling... {phoneNumber}";
        }

        public string SurfingInInternet(string site)
        {
            DoesItContainDigit(site);
            return $"Browsing: {site}!";
        }

        private void DoesItContainOnlyDigits(string phoneNumber)
        {
            if (phoneNumber.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException(NotOnlyDigitsException);
            }
        }

        private void DoesItContainDigit(string site)
        {
            if (site.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException(DigitException);
            }
        }
    }
}

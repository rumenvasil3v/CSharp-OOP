using _03.Telephony.IO.Interfaces;
using _03.Telephony.IO;
using _03.Telephony.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony.Models
{
    public class Stationary : ICallable
    {
        private const string NotOnlyDigitsException = "Invalid number!";

        public string Call(string phoneNumber)
        {
            DoesItContainOnlyDigits(phoneNumber);
            return $"Dialing... {phoneNumber}";
        }

        private void DoesItContainOnlyDigits(string phoneNumber)
        {
            if (phoneNumber.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException(NotOnlyDigitsException);
            }
        }
    }
}

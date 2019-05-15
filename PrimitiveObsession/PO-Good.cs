using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PrimitiveObsession.Good
{
    public class Address
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public ZipCode ZipCode { get; set; }
        public string Country { get; set; }
    }

    public class ZipCode
    {
        private readonly string _value;

        public ZipCode(string value)
        {
            // perform regex matching to verify XXXXX or XXXXX-XXXX format
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return _value;
        }
    }
}

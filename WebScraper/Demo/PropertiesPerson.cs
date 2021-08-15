/*
using System;

namespace WebScraper
{
    class Person
    {
        string _ssn = "SSN";
        string _passportData = "DATA";
        string _driversLicenseNumber = "MORE DATA";
        string _firstName = "Chris";
        string _lastName = "McColgan";

        // properties - a layer of abstraction on top of fields
        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenseNumber.Length > 0;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("input is not accepted");
                    return;
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("input is not accepted");
                    return;
                }
                _lastName = value;
            }
        }
    }
}
*/
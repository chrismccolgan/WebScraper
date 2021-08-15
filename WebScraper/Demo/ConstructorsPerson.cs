/*

using System;

namespace WebScraper
{
    class Person
    {
        string _ssn;
        string _passportData;
        string _driversLicenseNumber;

        // constructor
        public Person(string ssn, string passportData, string driversLicenseNumber)
        {
            _ssn = ssn;
            _passportData = passportData;
            _driversLicenseNumber = driversLicenseNumber;
        }

        // properties - a layer of abstraction on top of fields
        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenseNumber.Length > 0;
            }
        }
    }
}
*/
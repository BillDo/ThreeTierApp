using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class PatientBO : BaseBO
    {
        //Declaring UserRegistration Variables
        private string _FullName;
        private string _PassportId;
        private string _HealthInsuranceId;
        private DateTime _BoD;
        private bool _Gender;
        private string _Provinces;        
        private string _District;
        private string _Ward;
        private string _CurrentAddress;
        private string _Mobile;
        private string _Email;

        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

        public string PassportId
        {
            get
            {
                return _PassportId;
            }

            set
            {
                _PassportId = value;
            }
        }

        public string HealthInsuranceId
        {
            get
            {
                return _HealthInsuranceId;
            }

            set
            {
                _HealthInsuranceId = value;
            }
        }

        public DateTime BoD
        {
            get
            {
                return _BoD;
            }

            set
            {
                _BoD = value;
            }
        }

        public bool Gender
        {
            get
            {
                return _Gender;
            }

            set
            {
                _Gender = value;
            }
        }

        public string Provinces
        {
            get
            {
                return _Provinces;
            }

            set
            {
                _Provinces = value;
            }
        }

        public string District
        {
            get
            {
                return _District;
            }

            set
            {
                _District = value;
            }
        }

        public string Ward
        {
            get
            {
                return _Ward;
            }

            set
            {
                _Ward = value;
            }
        }

        public string CurrentAddress
        {
            get
            {
                return _CurrentAddress;
            }

            set
            {
                _CurrentAddress = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email; 
            }

            set
            {
                _Email = value;
            }
        }

        public string Mobile
        {

            get
            {
               return _Mobile;
            }
            set
            {
                _Mobile = value;
            }
        }
    }
}

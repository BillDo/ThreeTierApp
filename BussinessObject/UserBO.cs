using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class UserBO : BaseBO
    {
        //Declaring UserRegistration Variables
        private string _UserName;
        private string _Password;
        private string _Name;
        private string _Email;
        private string _Mobile;

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
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

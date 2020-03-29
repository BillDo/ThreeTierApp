using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class BaseBO // Declare Class Public to Access any where 
    {
        //Declaring UserRegistration Variables
        private string _Id;
        private string _CreatedBy;
        private string _CreatedAt;
        private string _ModifiedBy;
        private string _ModifiedAt;

        // Get and set values
        public string Id
        {
            get
            {
                return _Id;
            }
        }

        public string CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                _CreatedBy = value;
            }
        }

        public string CreatedAt
        {
            get
            {
                return _CreatedAt;
            }
            set
            {
                _CreatedAt = value;
            }
        }

        public string ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                _ModifiedBy = value;
            }
        }

        public string ModifiedAt
        {
            get
            {
                return _ModifiedAt;
            }
            set
            {
                _ModifiedAt = value;
            }
        }
    }
}

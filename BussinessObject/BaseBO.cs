﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class BaseBO // Declare Class Public to Access any where 
    {
        //Declaring UserRegistration Variables
        private int _Id;
        private bool _Status;
        private string _CreatedBy;
        private DateTime _CreatedAt;
        private string _ModifiedBy;
        private DateTime _ModifiedAt;

        // Get and set values
        public int Id
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

        public DateTime CreatedAt
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

        public DateTime ModifiedAt
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

        public bool Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
    }
}

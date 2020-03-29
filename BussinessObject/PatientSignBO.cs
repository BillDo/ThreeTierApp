using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessObject
{
    public class PatientSignBO : BaseBO
    {
        //Declaring UserRegistration Variables
        private int _PatientId;
        private bool _Fever;
        private bool _Cough;
        private bool _ShortnessInBreath;
        private bool _Pneumonia;
        private bool _StoreThroat;
        private bool _Tired;

        public int PatientId
        {
            get
            {
                return _PatientId;
            }
            set
            {
                _PatientId = value;
            }
        }

        public bool Fever
        {
            get
            {
                return _Fever;
            }

            set
            {
                _Fever = value;
            }
        }

        public bool Cough
        {
            get
            {
                return _Cough;
            }

            set
            {
                _Cough = value;
            }
        }

        public bool ShortnessInBreath
        {
            get
            {
                return _ShortnessInBreath; 
            }

            set
            {
                _ShortnessInBreath = value;
            }
        }

        public bool Pneumonia
        {

            get
            {
               return _Pneumonia;
            }
            set
            {
                _Pneumonia = value;
            }
        }

        public bool StoreThroat
        {

            get
            {
                return _StoreThroat;
            }
            set
            {
                _StoreThroat = value;
            }
        }

        public bool Tired
        {

            get
            {
                return _Tired;
            }
            set
            {
                _Tired = value;
            }
        }
    }
}

using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data members for properties
        private string mFirstName;
        private string mLastName;
        private string mEmail;

        // Public properties
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        // Constructor
        public clsCustomer()
        {
        }

        // Validation method
        public string Valid(string firstName, string lastName, string email)
        {
            string error = "";

            // Validate FirstName
            if (string.IsNullOrEmpty(firstName))
            {
                error += "First Name must not be empty. ";
            }
            if (firstName.Length > 50)
            {
                error += "First Name must be less than 50 characters. ";
            }

            // Validate LastName
            if (string.IsNullOrEmpty(lastName))
            {
                error += "Last Name must not be empty. ";
            }
            if (lastName.Length > 50)
            {
                error += "Last Name must be less than 50 characters. ";
            }

            // Validate Email
            if (string.IsNullOrEmpty(email))
            {
                error += "Email must not be empty. ";
            }
            if (email.Length > 100)
            {
                error += "Email must be less than 100 characters. ";
            }

            return error;
        }
    }
}

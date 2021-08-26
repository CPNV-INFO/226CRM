using System;

namespace CRM
{
    public class Contact
    {
        #region private attributes
        private string _name;
        private string _firstname;
        private DateTime _dateOfBirth;
        private string _nationality;
        private string _email;
        private string _pathToImg;
        #endregion private attributes

        #region public methods
        public Contact (string name, string firstname, DateTime dateOfBirth, string nationality, string email, string pathToImg = "/")
        {
            _name = name;
            _firstname = firstname;
            _dateOfBirth = dateOfBirth;
            _nationality = nationality;
            _email = email;
            _pathToImg = pathToImg;
        }

        public string Name
        {
            get
            {
                return _name;
            }           
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
        }

        public string Nationality
        {
            get
            {
                return _nationality;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

        public string PathToImg
        {
            get
            {
                return _pathToImg;
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}

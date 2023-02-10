using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{

    /// <summary>
    /// User Class...
    /// </summary>
    public class User
    {
        //Private fields
        private string firstName = null!;
        private string lastName = null!;
        private int age;
        private int birthMonth;
        private RoygbivEnum favoriteColor;
        private int siblings;

        /// <summary>
        /// Maintain the error message.
        /// </summary>
        public string? ErrorString { get; internal set; }

        /// <summary>
        /// First Name of the User.
        /// </summary>
        /// <remarks>This should never be empty</remarks>
        public string FirstName { get => firstName; set => firstName = ValidateFirstName(value); }
        /// <summary>
        /// Last Name of the User
        /// </summary>
        /// <remarks>This should not be Empty</remarks>
        public string LastName { get => lastName; set => lastName = ValidateLastName(value); }
        /// <summary>
        /// Age of User.
        /// </summary>
        /// <remarks>This must be greater then 0 and less then 130</remarks>
        public int Age { get => age; set => age = ValidateAge(value); }

        /// <summary>
        /// The birth month of the user
        /// </summary>
        /// <remarks>This needs to be between 1 and 12. Januray - December</remarks>
        public int BirthMonth { get => birthMonth; set => birthMonth = ValidateBirthMonth(value); }

        /// <summary>
        /// Favorite ROYGBIV Color 
        /// </summary>
        /// <remarks>Red, orange, yellow, green, blue, indigo, violet.</remarks>
        public RoygbivEnum FavoriteColor { get => favoriteColor; set => favoriteColor = value; }

        public int Siblings { get => siblings; set => siblings = value; }

        /// <summary>
        /// Validate the first name
        /// </summary>
        /// <param name="name"></param>
        private string ValidateFirstName(string name)
        {
            // Check for null or empty
            if (string.IsNullOrEmpty(name))
            {
                ErrorString = "First name can not be empty";
            }
            //Check length
            else if (name.Length > 50)
            {
                ErrorString = "First Name can not be longer then 50 charactor";
            }
            else
            {
                return name;
            }
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validate the last name.
        /// </summary>
        /// <param name="name"></param>
        private string ValidateLastName(string name)
        {
            // Check for null or empty
            if (string.IsNullOrEmpty(name))
            {
                ErrorString = "Last Name can not be empty";
            }
            //Check length
            else if (name.Length > 50)
            {
                ErrorString = "Last Name can not be longer then 50 charactor";
            }
            else
            {
                return name;
            }
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates age to be greater or equal then 0
        /// or less then 131
        /// </summary>
        /// <param name="howOld"></param>
        /// <returns>the int of the age</returns>
        /// <exception cref="ValidateException"></exception>
        private int ValidateAge(int howOld)
        {

            // the checks the vale to be greater or 
            if (howOld < 0)
            {
                ErrorString = "User's Age has to be at lest 0 years old";
            }
            else if (howOld > 130)
            {
                ErrorString = "User's Age has to be less then 131 years old";
            }
            else
            {
                return howOld;
            }
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates the month from 1 to 12
        /// </summary>
        /// <param name="month"></param>
        /// <returns>month</returns>
        /// <exception cref="ValidateException"></exception>
        public int ValidateBirthMonth(int month)
        {
            if (month <= 0)
            {
                ErrorString = "Birth Month must be greater then 0";
            }
            else if (month > 12)
            {
                ErrorString = "Birth Month must be less then or equal to 12";
            }
            else
            {
                return month;
            }
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates Siblings to be greater then 0
        /// or less then 10
        /// </summary>
        /// <param name="kids"></param>
        /// <returns>the int of the age</returns>
        /// <exception cref="ValidateException"></exception>
        private int ValidateSiblings(int kids)
        {

            // the checks the vale to be greater or 
            if (kids < 0)
            {
                ErrorString = "User's Siblings Count has to be at lest 0";
            }
            else if (kids > 130)
            {
                ErrorString = "User's Siblings count has to be less then 10";
            }
            else
            {
                return kids;
            }
            throw new ValidateException(ErrorString);
        }
        public override string ToString()
        {
            return $"{lastName}, {firstName}\nAge {age} years\nBirth Month {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(BirthMonth)}\nFavorite Color {favoriteColor}\nSiblings {Siblings}";
        }
    }
}

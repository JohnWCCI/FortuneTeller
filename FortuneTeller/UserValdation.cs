using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    internal static class UserValdation
    {
        /// <summary>
        /// Validate the first name
        /// </summary>
        /// <param name="name"></param>
        public static string ValidateFirstName(string name)
        {
            string ErrorString;
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
        public static string ValidateLastName(string name)
        {
            string ErrorString;

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
        public static int ValidateAge(int howOld)
        {
            string ErrorString;
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
        public static int ValidateBirthMonth(int month)
        {
            string ErrorString;
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
        public static int ValidateSiblings(int kids)
        {
            string ErrorString;
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
    }
}

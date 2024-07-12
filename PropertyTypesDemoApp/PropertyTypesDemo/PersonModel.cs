using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesDemo
{
    public class PersonModel
    {
        public string FirstName { private get; set; } // not anyone can read it, but anyone can set it
        public string LastName { get; private set; } // anyone can read it, but only inside this class can you set it

        private string _password;

        public string Password
        {
           // get { return myVar; }  // Delete the get because we have the private variable stored internally
            set { _password = value; }
        }
       

        public string FullName
        {
            get 
            { 
                return $"{FirstName}{LastName}"; 
            }
        }



        //public int Age { get; set; }
        private int _age;

        public int Age
        {
            get 
            { 
                return _age;
            }
            set 
            { 
                if (value >= 0 && value < 126) 
                { 
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }

        //public string SSN { get; set; }

        private string _ssn;

        public string SSN
        {
            get 
            {
                // 123-45-6789 -- 11 - 4 = 7
                string output = "***-**-" + _ssn.Substring(_ssn.Length-4);
                return output; 
            }
            set { _ssn = value; }
        }

        // Method overloading
        public PersonModel()
        {
            
        }


        public PersonModel(string lastName) // ctor + tab will create a constructor
        {
            LastName = lastName;
        }


    }
}

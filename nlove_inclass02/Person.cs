using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_inclass02
{//creating abstract class Person
    public abstract class Person
    {
        private string _firstName, _midInit, _lastName;
        private int _age;
        private readonly string _id;

        public string ID { get { return _id; } }
        // ID and FirstName - properties of class - can be called/used
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        // value - equal to what will be set when a new object is created
        public string MidInit
        {
            get
                {
                    return _midInit;
                }
            set
                {
                _midInit = value;
                }
         
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }

        public int Age { get { return _age; }
            set
            {
                if (value <0)
                {
                    _age = 0;
                    throw (new AgeBelowZeroException());
                }
                else
                {
                    _age = value;
                }
            }
        }
        //default constructor
        public Person() { }
        public Person(string id, string firstName, string midInit, string lastName, int age)
        {
            _id = id;
            FirstName = firstName;
            MidInit = midInit;
            LastName = lastName;
            Age = age;
        }
        // in abstract class- abstract methods are NOT defined
        public abstract string DisplayInformation();
    }
}

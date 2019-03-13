using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Employee : Person
    {
        private string _companyName;
        private Person _person;

        public string CompanyName
        {
            get
            {
                if (_companyName == "")
                    return "Без названия";
                else
                    return _companyName;
            }
        }
        public override string Fio
        {
            get
            {
                if (_person == null)
                    return "Без_имени";
                else
                    return _person.Fio;
            }
        }
        public override int Age
        {
            get
            {
                if (_person == null)
                    return 0;
                else
                    return _person.Age;
            }
        }
        public override int BirthYear
        {
            get
            {
                if (_person == null)
                    return 9999;
                else
                    return _person.BirthYear;
            }
        }

        public Employee(Person person, string companyName)
        {
            _person = person;
            _companyName = companyName;
        }

        

        public override string ToString()
        {
            return base.ToString() + ", работает в компании " + CompanyName;
        }
    }
}

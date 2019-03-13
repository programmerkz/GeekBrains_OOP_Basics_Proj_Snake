using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_project_Snake
{
    class Person
    {
        private int _birthYear;
        private string _fio;
        public virtual string Fio
        {
            get
            {
                if (_fio == "")
                    return "Без_имени";
                else
                    return _fio;
            }
        }
        public virtual int BirthYear { get { return _birthYear; } }
        public virtual int Age
        {
            get
            {
                DateTime curDateTime = DateTime.Now;

                if (_birthYear >= curDateTime.Year)
                    return 0;
                else
                    return (curDateTime.Year - BirthYear);
            }
        }

        public Person()
        {
            _fio = "";
            _birthYear = 9999;
        }
        public Person(string fio, int birthYear)
        {
            _fio = fio;
            _birthYear = birthYear;
        }
        protected void ChangeFio(string newFio)
        {
            _fio = newFio;
        }
        public override string ToString()
        {
            return Fio + ", " + BirthYear + "г.р., возраст " + Age;
        }
    }
}

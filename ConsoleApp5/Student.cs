using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student
    {
        private string _name;
        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name)
        //{
        //    _name = name;
        //}
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}

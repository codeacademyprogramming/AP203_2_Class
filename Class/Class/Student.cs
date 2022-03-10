using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Student:Human
    {
        public Student()
        {

        }
        public Student(int age,string groupNo):base(age)
        {
            GroupNo = groupNo;
        }
        public int AvgPoint;
        public string GroupNo = "AP";

        public string GetInfo()
        {
            string str = $"Fullname: {Name} {Surname} - Age: {Age} - GroupNo: {GroupNo}";
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadWriteXml
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }

        public float Average
        {
            get
            {
                return (Mark1 + Mark2) / 2;
            }
        
        }

        public Student(string id, string name, string phone, float mark1, float mark2)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Mark1 = mark1;
            Mark2 = mark2;
        }
    }
}
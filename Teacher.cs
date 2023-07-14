using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    public static class Teacher
    {
        private static string fullName;
        private static string  discipline;
        private static int id;

        public  static string FullName
        {
            get { return fullName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fullName = value;
                else
                    throw new ArgumentException("Full name cannot be empty.");
            }
        }

        public static string Discipline
        {
            get { return discipline; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    discipline = value;
                else
                    throw new ArgumentException("Discipline cannot be empty.");
            }
        }

        public static int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else
                    throw new ArgumentException("Id must be a positive integer.");
            }
        }
    }

}

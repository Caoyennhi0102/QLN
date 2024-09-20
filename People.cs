using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLN
{
    public  class People
    {
        private string FullName;
        private DateTime DateOfBrith;
        private string Sex;

        public string FullName1 { get => FullName; set => FullName = value; }
        public DateTime DateOfBrith1 { get => DateOfBrith; set => DateOfBrith = value; }
        public string Sex1 { get => Sex; set => Sex = value; }

        public People() { }

        public People(string fullName, DateTime dateOfBrith, string sex)
        {
            this.FullName = fullName;
            this.DateOfBrith = dateOfBrith;
            this.Sex = sex;
        }
    }
}

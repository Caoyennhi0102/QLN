using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLN
{
    public  class Student:People
    {
        private int MSSV;
        private string NganhHoc;
        private double Diem_TB;

        public int MSSV1 { get => MSSV; set => MSSV = value; }
        public string NganhHoc1 { get => NganhHoc; set => NganhHoc = value; }
        public double Diem_TB1 { get => Diem_TB; set => Diem_TB = value; }

        public Student() : base()
        {

        }
        public Student( string fullname,DateTime ngaysinh, string gioitinh,int mSSV, string nganhHoc, double diem_TB):base()
        {
            this.FullName1 = fullname;
            this.DateOfBrith1 = ngaysinh;
            this.Sex1 = gioitinh;
            this.MSSV = mSSV;
            this.NganhHoc = nganhHoc;
            this.Diem_TB = diem_TB;
            
        }
    }
}

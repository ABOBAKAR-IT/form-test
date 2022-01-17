using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formtest
{
    public class student
    {
        public  string name;
        public int rollno;
        public string clas;
        public void set(string n,int r,string c)
        {
            this.name =n;
            this.clas = c;
            this.rollno = r;
        }
    }
}

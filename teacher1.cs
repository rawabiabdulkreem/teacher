using System;
using System.Collections.Generic;
using System.Text;

namespace teacher
{
    class teacher1
    {
        public string tname, classname, sectionname;
        public int id;

        public teacher1(string _tname,string _classname, int id ,string _sectionname)
        {
          this.tname = _tname; this.classname = _classname; this.sectionname= _sectionname; this.id = 0;
        }

        public teacher1()
        {
        }

        public void setdetiles(string tname, string classname, int id, string sectionname)
        {
            this.tname = string.Empty; this.classname = string.Empty; this.id = 0; this.sectionname = string.Empty;
        }

        
        public void getdetiles()
        {
            Console.WriteLine($"{this.tname},{this.classname},{this.id},{this.sectionname}");
        }
    }
}

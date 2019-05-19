using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_2
{
    public class Teacher:Proson
    {
        public string call;
        public string branch;
        public void setdata(string name,string card,string call,string branch)
        {
            this.branch = branch;
            this.call = call;
            this.card = card;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"我是一名教师，编号：{card }叫{name}，职称为：{call}，所在部门：{branch}");
        }
    }
}

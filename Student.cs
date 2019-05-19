using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_2
{
    public class Student:Proson 
    {
        public string grade;
        public string mark;
        public void setdata(string name,string card,string grade,string mark)
        {
            this.card = card;
            this.grade = grade;
            this.mark = mark;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"我是一名学生，编号：{card}叫{name},所在班级为{grade},成绩{mark}");
        }
    }
}

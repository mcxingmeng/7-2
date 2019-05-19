using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            string name,card,grade,mark,call,branch;
            Console.WriteLine("添加一名学生：学生编号：");
            card = Console.ReadLine();               
            Console.WriteLine("添加一名学生：学生姓名：");
            name = Console.ReadLine();               
            Console.WriteLine("添加一名学生：学生班级：");
            grade = Console.ReadLine();               
            Console.WriteLine("添加一名学生：学生成绩：");
            mark = Console.ReadLine();
            a.setdata(name, card, grade, mark);
            Teacher b = new Teacher();
            Console.WriteLine("添加一名老师：老师编号：");
            card = Console.ReadLine();       
            Console.WriteLine("添加一名老师：老师姓名：");
            name = Console.ReadLine();       
            Console.WriteLine("添加一名老师：老师职称：");
            call = Console.ReadLine();      
            Console.WriteLine("添加一名老师：老师部门：");
            branch = Console.ReadLine();
            b.setdata(name,card,call,branch);
            a.display();
            b.display();
            Console.Read();
        }
    }
}

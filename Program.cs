using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();

            //try
            //{
            //    gen.Generate(42);

            //}
            //catch (Not42Exception ex)
            //{
            //    Console.WriteLine("Not42 exception appeared: ");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            Chatbox box = new Chatbox("Tony Stark");
            Chatbox box2 = new Chatbox("Sherlock");

            //HiChatter a, b;

            //a = box.SayHello;
            //a("Petya");
            //Console.WriteLine();
            //a = a + box2.SayHello;
            //a("Pupkin");
            //Console.WriteLine();
            //a = a + box.SayGoodbye;
            //a = a + box2.SayGoodbye;
            //a("Black Widow");
            //Console.WriteLine();

            //Action<string> act = box.SayHello;

            box.NewPersonArrived += Box_NewPersonArrived;

            box.Login("Dr.Strange");
            
            Console.ReadLine();
        }

        private static void Box_NewPersonArrived(object sender, NewPersonEventArgs args)
        {
            Console.WriteLine("New person with name {0} arrived at {1}", args.Name, args.Arrived);
        }
    }
}

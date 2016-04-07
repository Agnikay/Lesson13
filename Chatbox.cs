using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lesson_Code
{
    public delegate void HiChatter(string msg);
    public delegate string ChatNames();
    public delegate void NewPersonInChatEventHandler(object sender, NewPersonEventArgs args);


    public class Chatbox
    {
        private string chatName;
        Timer timer = new Timer();

        public event NewPersonInChatEventHandler NewPersonArrived;

        public Chatbox(string name)
        {
            chatName = name;
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rand = new Random();
            Login(rand.Next().ToString());
        }

        public void SayHello(string name)
        {
            Console.WriteLine(chatName +  " says Hello to " + name);
        }

        public string WhatIsYourName()
        {
            return chatName;
        }

        public void SayGoodbye(string someName)
        {
            Console.WriteLine(chatName + " says Bye to " + someName);
        }

        public void Login(string userName)
        {
            OnPersonArrived(userName);
        }

        public void OnPersonArrived(string name)
        {
            if (NewPersonArrived == null)
            {
                return;
            }

            NewPersonEventArgs args = new NewPersonEventArgs();
            args.Name = name;
            args.Arrived = DateTime.Now;
            NewPersonArrived(this, args);
        }
    }
}

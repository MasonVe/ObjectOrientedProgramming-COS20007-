using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._2
{
    public class Message
    {
        private string text;

        public Message(string txt)
        {
            text = txt;
        }

        public void Print()
        {
            Console.WriteLine(text);
        }


    }
}
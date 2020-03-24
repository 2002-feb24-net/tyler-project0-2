using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class Begin
    {
        public void Prompt()
        {
            string message = "Welcome to the Pizza Planet Console Application!";
            Console.WriteLine(message);
            Border(message);
        }

        public void Border(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Intro()
        {
            Prompt();

        }
    }
}

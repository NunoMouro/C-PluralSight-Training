using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Document : IStorable, ISpeak
    {
        public void Reformat()
        {
            Console.WriteLine("Reformating the document");

        }   

        public void Read(string nameOfFile)
        {
            Console.WriteLine($"Reading from {nameOfFile}");
        }

        public void Write(string nameOfFile)
        {
            Console.WriteLine($"Writing to {nameOfFile}");
        }

        public double DurationOfSpeach
        {
            get { return 42; }
        }

        public void Speak()
        {
            Console.WriteLine("Speaking...");
        }
    }
}

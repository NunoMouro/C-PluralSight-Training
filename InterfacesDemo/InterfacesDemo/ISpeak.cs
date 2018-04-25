using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public interface ISpeak
    {
        double DurationOfSpeach { get; }
        void Speak();
    }
}

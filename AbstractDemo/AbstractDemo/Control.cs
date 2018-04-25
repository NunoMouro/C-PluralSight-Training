using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class Control
    {
        protected int xPos;
        protected int yPos;

        public Control(          
            int xPosition,
            int yPosition)
        {
            xPos = xPosition;
            yPos = yPosition;
        }
        
        public virtual void Clear()
        {
            Console.WriteLine("Clearing control");
        }

        public abstract void Draw();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            List<Control> controls =
                new List<Control>();
            Button button = new Button(0, 100, "Click me");
            Listbox listBox = new Listbox(100, 300,
                new List<string>());
            Button cancelButton = new Button(150, 100, "Cancel Me");
            controls.Add(button);
            controls.Add(listBox);
            controls.Add(cancelButton);

            foreach(Control control in controls)
            {
                control.Draw();
            }
        }
    }

    
}

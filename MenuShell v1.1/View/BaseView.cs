using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell_v1._1.View
{
    abstract class BaseView
    {
        public string Title { get; }

        protected BaseView(string title)
        {
            Title = title;
            Console.Title = title;
        }

        public virtual void Display()
        {
            Console.WriteLine("BasicView");
        }
    }
}

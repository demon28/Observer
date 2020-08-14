using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Master : IObserver
    {

        public string _name;


        public Master(string name)
        {
            _name = name;
        }

        public void Response()
        {
            Console.WriteLine(_name + "我醒来");
        }
    }
}

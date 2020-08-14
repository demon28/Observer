using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Mouse : IObserver
    {

        public string _name;


        public Mouse (string name) {

            _name = name;
        }


        public void Response()
        {
            Console.WriteLine(_name+"开始逃跑");
        }
    }
}

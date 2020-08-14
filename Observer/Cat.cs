using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
   public class Cat:Subject
    {

        public event EventHandler OnCrying;


        public void Cry() {


            Console.WriteLine("猫叫了！。。。");
            notify();
        }


        public void notify()
        {
            OnCaying();
        }
    }
}

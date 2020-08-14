using System;

namespace Observer
{


    //定义一个全局的委托类型

    public delegate void EventHandler();

    class Program
    {
        static void Main(string[] args)
        {


            Cat cat = new Cat();

            IObserver mouse = new Mouse("赵铁柱");
            IObserver master = new Master("王钢蛋");
            IObserver mouse2 = new Mouse("铁锤妹妹");

            cat.OnCrying +=new EventHandler(mouse.Response);
            cat.OnCrying +=new EventHandler(master.Response);
            cat.OnCrying += new EventHandler(mouse2.Response);

            cat.Cry();
        }
    }
}

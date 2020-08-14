using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
    /// <summary>
    /// 订阅者
    /// </summary>
    class Subscriber : IObserver
    {


        public string Name { get; set; }
        public Subscriber(string name)
        {
            this.Name = name;
        }


        public void ReceiveAndPrint(TenXun tenxun)
        {
            Console.WriteLine(Name + "您好，氪金的时刻到了。。。" + tenxun._symbol + "游戏:" + tenxun._info);
        }
    }
}

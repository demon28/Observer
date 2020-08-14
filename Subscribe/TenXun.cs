using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{

   //订阅号
   public abstract  class TenXun
    {
        public List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// 标识 或者 叫名称
        /// </summary>
        public string _symbol { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string _info { get; set; }


        public TenXun(string sysbol,string info)
        {
            _symbol = sysbol;
            _info = info;
        }


        public void AddOberver(IObserver ob) {

            observers.Add(ob);
        }

        public void RemoveOberver(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void Notify() {

            foreach (var item in observers)
            {
                if (item!=null)
                {
                    item.ReceiveAndPrint(this);
                }
            }
        
        
        }








    }
}

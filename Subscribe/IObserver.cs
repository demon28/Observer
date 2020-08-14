using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
   public interface IObserver
    {
        //接收通知并打印通知
        void ReceiveAndPrint(TenXun tenxun);

    }
}

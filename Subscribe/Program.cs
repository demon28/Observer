using System;

namespace Subscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            TenXun tenXun = new TenXunGame("王者容易", "出XX皮肤咯,只要100块");
            TenXun tenXun1 = new TenXunQQ("QQ", "QQ绿钻，听歌8折");

            tenXun.AddOberver(new Subscriber("王二狗"));
            tenXun.AddOberver(new Subscriber("川建国"));

            tenXun1.AddOberver(new Subscriber("王二狗"));
           

            tenXun.Notify();
            tenXun1.Notify();

        }
    }
}

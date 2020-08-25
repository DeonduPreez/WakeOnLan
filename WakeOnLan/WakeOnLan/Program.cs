using System.Threading.Tasks;

namespace WakeOnLan
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string mac = "01-02-03-04-05-06";
            await WOL.WakeOnLan(mac);
        }
    }
}
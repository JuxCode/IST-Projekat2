using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(IST_Projekat2.Service1));
            sh.Open();
            Console.WriteLine("Servis je pokrenut. Pritisnite enter za zaustavljanje...");
            Console.ReadLine();
            Console.WriteLine("Zaustavljam servis...");
            sh.Close();
        }
    }
}

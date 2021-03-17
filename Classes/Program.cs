using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            IMagazaManager kasapReyonu = new KasapReyonu();
            IMagazaManager manavReyonu = new ManavReyonu();
            IMagazaManager sarkuteriReyonu = new SarkuteriReyonu();
            BossManager bossManager = new BossManager();
            bossManager.Add(new FırınReyonu());
            bossManager.Update(new FırınReyonu());

           

            




        }
    }
}

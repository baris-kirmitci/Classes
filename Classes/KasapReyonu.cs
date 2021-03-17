using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class KasapReyonu : IMagazaManager
    {
        public void Add()
        {
           Console.WriteLine("Manav Reyonuna Ürün Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Kasap Reyonu Güncellendi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class SarkuteriReyonu : IMagazaManager
    {
        public void Add()
        {
            Console.WriteLine("Şarküteri Reyonuna Ürün Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Şarküteri Reyonu Güncellendi");
        }
    }
}

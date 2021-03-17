using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class ManavReyonu : IMagazaManager
    {
        public void Add()
        {
            Console.WriteLine("Manav Reyonuna Ürün Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Manav Reyonu Güncellendi");
        }
    }
}

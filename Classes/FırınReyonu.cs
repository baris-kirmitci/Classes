using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class FırınReyonu : IMagazaManager
    {
        public void Add()
        {
            Console.WriteLine("Fırına Reyonuna Ürün Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Fırın Reyonu Güncellendi");
        }
    }
}

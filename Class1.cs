using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class BossManager
    {
        public void Add(IMagazaManager magazaManager)
        {
            magazaManager.Add();
            
        }
        public void Update(IMagazaManager magazaManager)
        {
            magazaManager.Update();
        }
       
    }
}

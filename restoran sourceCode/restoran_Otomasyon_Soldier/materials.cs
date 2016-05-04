using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace restoran_Otomasyon_Soldier
{
   public class materials : warbase
   {
      public string Name { get; set; }

      public override string ToString()
      {
         return this.Name;
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace restoran_Otomasyon_Soldier
{
   public class orders : warbase
   {
      public string Name { get; set; }
      public int Count { get; set; }
      public string HamurTipi { get; set; }
      public string Icecek { get; set; }
      public string Boyut { get; set; }
      public DateTime Zaman { get; set; }
      public int BayiId { get; set; }
      public decimal Fiyat { get; set; }


      public override string ToString()
      {
         return this.Name;
      }
   }
}

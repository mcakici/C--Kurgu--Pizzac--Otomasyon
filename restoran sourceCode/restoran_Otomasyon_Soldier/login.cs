using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace restoran_Otomasyon_Soldier
{
   public class login : warbase
   {
      public string Username { get; set; }
      public string Password { get; set; }
      public int Type { get; set; }
      public string Address { get; set; }
      public string Phone { get; set; }
      public string Firstname { get; set; }
      public string Lastname { get; set; }
      public bool Status { get; set; }
      string tip;

      public override string ToString()
      {
         
         switch(Type){
            case 1: tip = "Admin"; break;
               case 2: tip = "Bayi"; break;
               case 3: tip = "Müşteri"; break;
         }
         return this.Username+" > "+this.tip;
      }
   }
}

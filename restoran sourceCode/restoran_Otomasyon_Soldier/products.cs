using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;

namespace restoran_Otomasyon_Soldier
{
    public class products : warbase
    {
       public string Name { get; set; }
       public string Desc { get; set; }
       public string ImgPath { get; set; }
       public string Materials{ get; set; }
       public string Price { get; set; }
       public bool status { get; set; }
       

       public override string ToString()
       {
          return this.Name;
       }
    }
}

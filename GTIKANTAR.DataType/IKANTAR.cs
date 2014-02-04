using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.DataType
{
    interface IKANTAR
    {
        decimal ID { get; set; }

         string TIP { get; set; }

         string PLAKA { get; set; }

         string DORSE { get; set; }

         DateTime? ILKTARTIMTARIHI { get; set; }


        //Dolu Boş Bilgisini Barındıracak
         string ALAN1 { get; set; }

        //ALAN2 Yerine araç eğer Aynı Gün içinde İkinci Kez Tartılıyorsa Nedeni Yazılır. Zorunlu Alan Olacak
          string ALAN2 { get; set; }

        //   public string ALAN3 { get; set; }

        //  public string ALAN4 { get; set; }
        //2014
         decimal? TARTIM1 { get; set; }

        //  public decimal TARTIM2 { get; set; }

         string KULLANICI { get; set; }

         Guid ROWID { get; set; }


    }
}

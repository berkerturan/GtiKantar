using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.DataType
{
    interface IKANTAR
    {
        public decimal ID { get; set; }

        public string TIP { get; set; }

        public string PLAKA { get; set; }

        public string DORSE { get; set; }

        public DateTime? ILKTARTIMTARIHI { get; set; }


        //Dolu Boş Bilgisini Barındıracak
        public string ALAN1 { get; set; }

        //  public string ALAN2 { get; set; }

        //   public string ALAN3 { get; set; }

        //  public string ALAN4 { get; set; }
        //2014
        public decimal? TARTIM1 { get; set; }

        //  public decimal TARTIM2 { get; set; }

        public string KULLANICI { get; set; }

        public Guid ROWID { get; set; }


    }
}

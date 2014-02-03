using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.DataType
{
    public class KANTAR_KAPI : IKANTAR
    {
        //Kapıdaki DB'ye de Merkezdeki db'ye de TARTIMNO olarak yazılacak.
        [TablePrimaryKey(TablePrimaryKeyName = "ID")]
        public decimal ID { get; set; }

        //Silinmiş veriler için S, Değiştirilmiş veriler için D, İlk Kayıtlar için 'C' kullanılacak. 'G' Kaydı kullanılmamaktadır.
        public string TIP { get; set; }

        public string PLAKA { get; set; }

        public string DORSE { get; set; }

        public DateTime? ILKTARTIMTARIHI { get; set; }

        public string ALAN1 { get; set; }

        public decimal? TARTIM1 { get; set; }

        public string KULLANICI { get; set; }

        public Guid ROWID { get; set; }

        public bool? MERKEZEYAZILDIMI { get; set; }
        //Clientdaki Kantar satırının ID'si alınacak.
        public decimal? TARTIMNO { get; set; }
        //Config Dosyasından KANTARID alınacak.
        public decimal? KANTARLAR { get; set; }

    }
}

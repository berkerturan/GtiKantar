using System;
using Petaframe.DataAccess;
using GTIKANTAR.DataType;

namespace GTIKANTAR.DataType
{
    [TableName("KANTAR_ARAC")]
    public class KANTAR_MALZEME 
    {
        [TablePrimaryKey(TablePrimaryKeyName = "MALZEMEID")]
        public Guid MALZEMEID { get; set; }

        public string MALZEMEKODU { get; set; }

        public string MALZEMEADI { get; set; }

        public string OZELLIK { get; set; }

        public decimal BIRIMFIYATI { get; set; }

        public string KDV { get; set; }
    }
}

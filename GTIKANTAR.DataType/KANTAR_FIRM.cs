using System;
using Petaframe.DataAccess;
using GTIKANTAR.DataType;

namespace GTIKANTAR.DataType
{
    [TableName("KANTAR_FIRM")]
    public class KANTAR_FIRM
    {
        [TablePrimaryKey(TablePrimaryKeyName = "FIRMID")]
        public Guid FIRMID { get; set; }

        public string FIRMAKODU { get; set; }

        public string FIRMAADI { get; set; }

        public string ADRES1 { get; set; }

        public string ADRES2 { get; set; }

        public string VERGIDAIRESI { get; set; }

        public string VERGINO { get; set; }
    }
}

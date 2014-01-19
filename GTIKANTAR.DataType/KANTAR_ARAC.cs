using System;
using Petaframe.DataAccess;
using GTIKANTAR.DataType;
namespace GTIKANTAR.DataType
{
     [TableName("KANTAR_ARAC")]
    public class KANTAR_ARAC 
    {
        [TablePrimaryKey(TablePrimaryKeyName = "ARACID")]
        public Guid ARACID { get; set; }

        public string PLAKA { get; set; }

        public Guid FIRMAID { get; set; }

        public Guid MALZEMEID { get; set; }
    }
}

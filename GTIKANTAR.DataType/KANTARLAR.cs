using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIKANTAR.DataType
{
    [TableName("KANTARLAR")]
    public class KANTARLAR
    {
        [TablePrimaryKey(TablePrimaryKeyName = "ID")]
        public decimal ID { get; set; }

        public string ADI { get; set; }

        public decimal KAPI { get; set; }

        public string DOSYA_YOLU { get; set; }
        public string DOSYA_UZANTI { get; set; }
        public Guid ROWID { get; set; }
    }
}

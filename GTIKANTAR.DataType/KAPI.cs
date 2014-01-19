using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIKANTAR.DataType
{

    [TableName("KAPI")]
    public class KAPI
    {
        [TablePrimaryKey(TablePrimaryKeyName = "ID")]
        public decimal ID { get; set; }

        public string ADI { get; set; }

        public int ERPBRANCHID { get; set; }



    }
}

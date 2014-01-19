
using System;
using Petaframe.DataAccess;

namespace GTIKANTAR.DataType
{
    [TableName("EMPLOYEES")]
    public class EMPLOYEES
    {
        [TablePrimaryKey(TablePrimaryKeyName = "EMPLOYEEID")]
        public long EMPLOYEEID { get; set; }

        public string FNAME { get; set; }

        public string LNAME { get; set; }

        public string USERNAME { get; set; }

        public string PASWORD { get; set; }

        public string ISACTIVE { get; set; }

        public string EMAIL { get; set; }

    }
}


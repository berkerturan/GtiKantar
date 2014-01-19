using System;
using System.Collections.Generic;
using System.Data;
using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System.Text;

namespace GTIKANTAR.Business
{
   public class KAPIBS : BusinessBase
    {
        public KAPIBS(string ConnectionString)
            : base(ConnectionString)
        {

        }

        public bool Kaydet(KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(employees) > 0 ? true : false;
        }
        public bool Guncelle(KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(employees) > 0 ? true : false;
        }
        public bool Sil(KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(employees) > 0 ? true : false;
        }
        public IEnumerable<KAPI> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KAPI>();
        }
    }
}

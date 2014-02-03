using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.Business
{
  public  class KANTAR_KAPIBS: BusinessBase
    {
      public KANTAR_KAPIBS(string ConnectionString)
            : base(ConnectionString)
        {

        }

        public bool Kaydet(KANTAR_KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(employees) > 0 ? true : false;
        }
        public bool Guncelle(KANTAR_KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(employees) > 0 ? true : false;
        }
        public bool Sil(KANTAR_KAPI employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(employees) > 0 ? true : false;
        }
        public IEnumerable<KANTAR_KAPI> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KANTAR_KAPI>();
        }
        public IEnumerable<KANTAR_KAPI> ListeleSinceYesterday()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KANTAR_KAPI>("select * from KANTAR where TARIH> DATEADD(day,-1,getdate())");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System.Text;

namespace GTIKANTAR.Business
{
  public  class KANTARLARBS: BusinessBase
    {
      public KANTARLARBS(string ConnectionString)
            : base(ConnectionString)
        {

        }

        public bool Kaydet(KANTARLAR employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(employees) > 0 ? true : false;
        }
        public bool Guncelle(KANTARLAR employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(employees) > 0 ? true : false;
        }
        public bool Sil(KANTARLAR employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(employees) > 0 ? true : false;
        }
        public IEnumerable<KANTARLAR> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KANTARLAR>();
        }
        public IEnumerable<KANTARLAR> Listele(long KAPIID)
        {
            ISqlServerDataService data = GetSqlServerDataObject();
            data.AddInputParameter("@ID", KAPIID, DbType.Int64);
            return data.FindAll<KANTARLAR>("select * from KANTARLAR where KAPI=@ID");
        }
    }
}

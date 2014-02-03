using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.Business
{
  public  class KANTAR_LOCALBS: BusinessBase
    {
      public KANTAR_LOCALBS(string ConnectionString)
            : base(ConnectionString)
        {

        }

        public bool Kaydet(KANTAR_LOCAL employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(employees) > 0 ? true : false;
        }
        public bool Guncelle(KANTAR_LOCAL employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(employees) > 0 ? true : false;
        }
        public bool Sil(KANTAR_LOCAL employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(employees) > 0 ? true : false;
        }
        public IEnumerable<KANTAR_LOCAL> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KANTAR_LOCAL>();
        }   
    }
}

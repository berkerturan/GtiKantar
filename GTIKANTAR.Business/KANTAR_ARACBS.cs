using System;
using System.Collections.Generic;
using System.Data;
using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System.Text;
using System.Configuration;

namespace GTIKANTAR.Business
{
  public  class KANTAR_ARACBS: BusinessBase
    {
      public KANTAR_ARACBS(string ConnectionString)
          : base(ConnectionString)
      {

      }


      public bool Kaydet(KANTAR_ARAC item)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(item) > 0 ? true : false;
        }
      public bool Guncelle(KANTAR_ARAC item)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(item) > 0 ? true : false;
        }
      public bool Sil(KANTAR_ARAC item)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(item) > 0 ? true : false;
        }
      public IEnumerable<KANTAR_ARAC> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<KANTAR_ARAC>();
        }
    }
}

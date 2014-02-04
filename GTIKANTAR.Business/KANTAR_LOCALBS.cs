using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
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
        public KANTAR_LOCAL Listele(decimal TartimNo)
        {
            ISqlServerDataService data = GetSqlServerDataObject();
           
            data.AddInputParameter("@ID", TartimNo, DbType.Decimal);
            return data.FindBy<KANTAR_LOCAL>("select Top 1* from KANTAR where (ID=@ID and ILKTARTIMTARIHI> DATEADD(day,-1,getdate()) and TIP!='S') Order by ID desc ");
        }
    }
}

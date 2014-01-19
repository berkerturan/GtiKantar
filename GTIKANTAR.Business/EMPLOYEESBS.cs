using System;
using System.Collections.Generic;
using System.Data;
using GTIKANTAR.DataType;
using Petaframe.DataAccess;
using System.Text;

namespace GTIKANTAR.Business
{
    public class EMPLOYEESBS : BusinessBase
    {
        public EMPLOYEESBS(string ConnectionString)
            : base(ConnectionString)
        {

        }

        public bool Kaydet(EMPLOYEES employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Insert(employees) > 0 ? true : false;
        }
        public bool Guncelle(EMPLOYEES employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Update(employees) > 0 ? true : false;
        }
        public bool Sil(EMPLOYEES employees)
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.Delete(employees) > 0 ? true : false;
        }
        public IEnumerable<EMPLOYEES> Listele()
        {
            ISqlServerDataService data = GetSqlServerDataObject();

            return data.FindAll<EMPLOYEES>();
        }
        public EMPLOYEES KullaniciAdiSifreKontrol(string KullaniciAdi, string Sifre)
        {
            ISqlServerDataService data = GetSqlServerDataObject();
            data.AddInputParameter("@Username", KullaniciAdi, DbType.String);
            data.AddInputParameter("@Pasword", Sifre, DbType.String);
            return data.FindBy<EMPLOYEES>("select Top 1 * from EMPLOYEES where USERNAME=@Username and PASWORD=@Pasword");
        }
//Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

//    config.AppSettings.Settings.Add("YourKey", "YourValue");

//    config.Save(ConfigurationSaveMode.Minimal);    
    }
}

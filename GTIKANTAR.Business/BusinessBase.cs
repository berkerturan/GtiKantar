using System;
using System.Data;
using System.Diagnostics;
using Petaframe.DataAccess;
using System.Configuration;
using Petaframe.Logging;
using System.Text;
using Petaframe.Security;

namespace GTIKANTAR.Business
{
    public enum TableOperations
    {
        select = 0,
        insert,
        update,
        delete,
    }
    public class BusinessBase:IDisposable
    {
        protected string Query { get; set; }
        private readonly string _connectionString;
        public BusinessBase(string connectionString)
        {
            
            _connectionString =Crytography.Decrypt( connectionString,Petaframe.Security.Crytography.HashType.AES);
        }
       
        /// <summary>
        /// �zerinde �al���lan projeye ait instance d�nd�r�r (�rn. KullaniciBS)
        /// </summary>
        /// <returns>Oracle veya SqlServer veritaban�yla �al��abilen projeye ait nesne (�rn. KullaniciBS)</returns>
        protected virtual IDataService GetDataObject()
        {
            return new OracleDataService(_connectionString);

        }

        /// <summary>
        /// SqlServer ile �al��mak i�in gereken metodlar� i�eren s�n�f� d�nd�r�r.
        /// </summary>
        /// <returns><see cref="SqlServerDataService"/></returns>
        protected virtual ISqlServerDataService GetSqlServerDataObject()
        {
            return new SqlServerDataService(_connectionString);
        }

        /// <summary>
        /// Oracle ile �al��mak i�in gereken metodlar� i�eren s�n�f� d�nd�r�r.
        /// </summary>
        /// <returns><see cref="OracleDataService"/></returns>
        protected virtual IOracleDataService GetOracleDataObject()
        {
            return new OracleDataService(_connectionString);
        }


        /// <summary>
        /// Olu�an hatay� loglar
        /// </summary>
        /// <param name="severity">Loga yaz�lacak i�lemin �nem derecesi</param>
        /// <param name="ex">Olu�an hata (Exception)</param>
        /// <param name="pageUrl">Hatan�n olu�tu�u sayfa</param>
        /// <param name="methodName">Hatan�n olu�tu�u metod</param>
        /// <param name="message">Hata ile ilgili mesaj</param>
        /// <param name="extraParameters">Varsa extra parametreler</param>
        protected void Log(LogSeverity severity, Exception ex, string pageUrl, string methodName, string message, params string[] extraParameters)
        {

            EventLogLogger log = new EventLogLogger();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Exception :");
            sb.AppendLine(ex.Message);
            sb.AppendLine("form yada sayfa ad�:");
            sb.AppendLine(pageUrl);
            sb.AppendLine("metod ad� : ");
            sb.AppendLine(methodName);
            sb.AppendLine("mesaj :");
            sb.AppendLine(message);
            sb.AppendLine("di�er parametreler :");

            foreach (var item in extraParameters)
            {
                sb.AppendLine(item);
            }

            log.Log(severity, "Business", sb.ToString());

        }



        /// <summary>
        /// Olu�an hatay� loglar
        /// </summary>
        /// <param name="severity">Loga yaz�lacak i�lemin �nem derecesi</param>
        /// <param name="ex">Olu�an hata (Exception)</param>
        /// <param name="pageUrl">Hatan�n olu�tu�u sayfa</param>
        /// <param name="methodName">Hatan�n olu�tu�u metod</param>
        /// <param name="message">Hata ile ilgili mesaj</param>
        /// <param name="kullaniciSicil">Varsa kullan�c�n�n ad�</param>
        /// <param name="pcName">��lemi yapan kullan�c�ya ait pc ad�</param>
        /// <param name="extraParameters">Varsa extra parametreler</param>
        protected void Log(LogSeverity severity, Exception ex, string pageUrl, string methodName, string message, string user, string pcname, params string[] extraParameters)
        {


            EventLogLogger log = new EventLogLogger();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Exception :");
            sb.AppendLine(ex.Message);
            sb.AppendLine("form yada sayfa ad�:");
            sb.AppendLine(pageUrl);
            sb.AppendLine("metod ad� : ");
            sb.AppendLine(methodName);
            sb.AppendLine("mesaj :");
            sb.AppendLine(message);
            sb.AppendLine("kullan�c� :");
            sb.AppendLine(user);
            sb.AppendLine("bilgisayar ad� :");
            sb.AppendLine(pcname);
            sb.AppendLine("di�er parametreler :");

            foreach (var item in extraParameters)
            {
                sb.AppendLine(item);
            }

            log.Log(severity, "Business", sb.ToString());
        }

        /// <summary>
        /// Tablo �zerinde yap�lan i�lemlerin(insert ,update ,delete) loglanmas� amac�yla haz�rlanm��t�r.
        /// </summary>
        /// <param name="tableName">Tablo Ad�</param>
        /// <param name="rowid">Veriye ait ID</param>
        /// <param name="columnName">S�tun Ad�</param>
        /// <param name="operation">Tablo �zerinde yap�lan i�lem</param>
        /// <param name="user">��lemi yapan kullan�c�</param>
        /// <param name="projectname">�zerinde �al���lan proje ad�</param>
        /// <param name="oldvalue">Tablodaki eski de�er</param>
        /// <param name="newvalue">Tablodaki yeni de�er</param>
        /// <param name="message">Varsa i�lem ile ilgili mesaj</param>
        protected void LogAudit(string tableName, string rowid, string columnName, TableOperations operation, string user, string projectname, string oldvalue, string newvalue, string message)
        {

            EventLogLogger log = new EventLogLogger();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tablo ad� :");
            sb.AppendLine(tableName);
            sb.AppendLine("sat�r id :");
            sb.AppendLine(rowid);
            sb.AppendLine("s�tun ad� :");
            sb.AppendLine(columnName);
            sb.AppendLine("yap�lan i�lem");
            sb.AppendLine(Enum.GetName(typeof(TableOperations), operation));
            sb.AppendLine("kullan�c� :");
            sb.AppendLine(user);
            sb.AppendLine("uygulama ad� :");
            sb.AppendLine(projectname);
            sb.AppendLine("orijinal de�er");
            sb.AppendLine(oldvalue);
            sb.AppendLine("yeni de�er");
            sb.AppendLine(newvalue);
            sb.AppendLine("mesaj :");
            sb.AppendLine(message);
            log.LogInfo("Audit", sb.ToString());
        }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

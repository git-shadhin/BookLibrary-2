using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALExemp : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALExemp(string Connection)
            : base(Connection, mappingSource)
        { 
        
        }

        [Function(Name = "[dbo].[Exemp_SelectAll]")]
        public ISingleResult<ClsBOExemp> SelectAllExemp()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemp_SelectByBiblioID]")]
        public ISingleResult<ClsBOExemp> SelectExempByBiblioID([Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Biblio_ID);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemp_SelectByISBN]")]
        public ISingleResult<ClsBOExemp> SelectExempByISBN([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemp_SelectByEtat]")]
        public ISingleResult<ClsBOExemp> SelectExempByEtat([Parameter(Name = "@Etat_ID", DbType = "int")] Int32 Etat_ID)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Etat_ID);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemp_SelectByISBNAndBiblioID]")]
        public ISingleResult<ClsBOExemp> SelectExempByISBNAndBiblioID([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN, 
                                                                      [Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN, Biblio_ID);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemplaire_Add]")]
        public ISingleResult<ClsBOExemp> AddExemplaire([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN,
                                                       [Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN, Biblio_ID);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Exemp_SelectEtatByExempID]")]
        public ISingleResult<ClsBOExemp> AddExemplaire([Parameter(Name = "@Exemp_ID", DbType = "int")] Int32 Exemp_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Exemp_ID);
            return ((ISingleResult<ClsBOExemp>)(result.ReturnValue));
        }
    }
}
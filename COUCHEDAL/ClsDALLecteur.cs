using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using COUCHEBO;

namespace COUCHEDAL
{
    public class ClsDALLecteur : DataContext
    {
        private static readonly System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALLecteur(string Connection)
            : base(Connection, mappingSource)
        { 
        
        }

        [Function(Name = "[dbo].[Lecteur_SelectAll]")]
        public ISingleResult<ClsBOLecteur> SelectAllLecteur()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOLecteur>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Lecteur_SelectByUsername]")]
        public ISingleResult<ClsBOLecteur> SelectLecteurByUsername([Parameter(Name = "@Username", DbType = "varchar")] String Username)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Username);
            return ((ISingleResult<ClsBOLecteur>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Lecteur_Login]")]
        public ISingleResult<ClsBOLecteur> Login([Parameter(Name = "@Username", DbType = "varchar(50)")] String Username, 
                                                 [Parameter(Name = "@Password", DbType = "varchar(16)")] String Password)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Username, Password);
            return ((ISingleResult<ClsBOLecteur>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Lecteur_SelectNb_EmpruntByLecteurID]")]
        public ISingleResult<ClsBOLecteur> SelectNb_EmpruntByLecteurID([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOLecteur>)(result.ReturnValue));
        }

        
    }
}

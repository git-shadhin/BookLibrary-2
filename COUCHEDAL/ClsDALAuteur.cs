using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using COUCHEBO;

namespace COUCHEDAL
{
    public class ClsDALAuteur : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALAuteur(string connection) :
            base(connection, mappingSource)
        {
        }

        [Function(Name = "[dbo].[Auteur_SelectAll]")]
        public ISingleResult<ClsBOAuteur> SelectAllAuteur()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOAuteur>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Auteur_AddAuteur]")]
        public ISingleResult<ClsBOAuteur> AddAuteur([Parameter(Name = "@AuteurNom", DbType = "varchar(50)")] String Nom,
                                                    [Parameter(Name = "@AuteurPrenom", DbType = "varchar(50)")] String Prenom)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Nom, Prenom);
            return ((ISingleResult<ClsBOAuteur>)(result.ReturnValue));
        }
    }
}

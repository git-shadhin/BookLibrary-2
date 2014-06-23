using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALLecteur_Bibliotheque: DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALLecteur_Bibliotheque(string Connection) :
            base(Connection, mappingSource)
        { 
        }

        [Function(Name = "[dbo].[Lecteur_Biblio_SelectAll]")]
        public ISingleResult<ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOLecteur_Bibliotheque>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Lecteur_Biblio_SelectByLecteurID]")]
        public ISingleResult<ClsBOLecteur_Bibliotheque> SelectLecteurBiblioByLecteurID([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOLecteur_Bibliotheque>)(result.ReturnValue));
        }
    }
}

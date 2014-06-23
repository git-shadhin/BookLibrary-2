using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALGestion_Bibliotheque : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALGestion_Bibliotheque(string Connection) :
            base(Connection, mappingSource)
        { 
        }

        [Function(Name = "[dbo].[Gestion_Biblio_SelectAll]")]
        public ISingleResult<ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOGestion_Bibliotheque>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Gestion_Biblio_SelectWhereIsAdmin]")]
        public ISingleResult<ClsBOGestion_Bibliotheque> SelectWhereIsAdmin([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID,
                                                                              [Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID, Biblio_ID);
            return ((ISingleResult<ClsBOGestion_Bibliotheque>)(result.ReturnValue));
        }
    }
}

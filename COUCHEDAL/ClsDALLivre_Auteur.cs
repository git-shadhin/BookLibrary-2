using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALLivre_Auteur : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALLivre_Auteur(string Connection) :
            base(Connection, mappingSource)
        {
        }

        [Function(Name = "[dbo].[Livre_Auteur_SelectAll]")]
        public ISingleResult<ClsBOLivre_Auteur> SelectAllLivreAuteur()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOLivre_Auteur>)(result.ReturnValue));
        }
    }
}

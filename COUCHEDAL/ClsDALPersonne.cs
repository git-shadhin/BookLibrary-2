using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALPersonne : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALPersonne(string Connection) :
            base(Connection, mappingSource)
        { 
        }

        [Function(Name = "[dbo].[Personne_SelectAll]")]
        public ISingleResult<ClsBOPersonne> SelectAllPersonne()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOPersonne>)(result.ReturnValue));
        }
    }
}

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using COUCHEBO;

namespace COUCHEDAL
{
    public class ClsDALBiblio : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALBiblio(string connection) :
            base(connection, mappingSource)
        {
        }

        [Function(Name = "[dbo].[Biblio_SelectAll]")]
        public ISingleResult<ClsBOBiblio> SelectAllBiblio()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOBiblio>)(result.ReturnValue));
        }
    }
}

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using COUCHEBO;

namespace COUCHEDAL
{
    public class ClsDALGenre : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALGenre(string Connection)
            : base(Connection, mappingSource)
        { 
        
        }

        [Function(Name = "[dbo].[Genre_SelectAll]")]
        public ISingleResult<ClsBOGenre> SelectAllGenre()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOGenre>)(result.ReturnValue));
        }
    }
}

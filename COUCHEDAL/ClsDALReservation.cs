using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL 
{
    public class ClsDALReservation : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALReservation(string Connection) :
            base(Connection, mappingSource)
        { 
        }

        [Function(Name = "[dbo].[Reservation_SelectAll]")]
        public ISingleResult<ClsBOReservation> SelectAllReservation()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOReservation>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Reservation_Reserver]")]
        public ISingleResult<ClsBOReservation> Reserver([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN, 
                                                        [Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN, Lecteur_ID);
            return ((ISingleResult<ClsBOReservation>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Reservation_EnCoursByUtilisateur]")]
        public ISingleResult<ClsBOReservation> SelectReservEnCoursByUtilisateur([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOReservation>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Reservation_HistoriqueByUtilisateur]")]
        public ISingleResult<ClsBOReservation> SelectReservHistoriqueByUtilisateur([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOReservation>)(result.ReturnValue));
        }
    }
}

using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALEmprunt : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALEmprunt(string Connection) :
            base(Connection, mappingSource)
        {
        }

        [Function(Name = "[dbo].[Emprunt_SelectAll]")]
        public ISingleResult<ClsBOEmprunt> SelectAllEmprunt()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_EnCoursByUtilisateur]")]
        public ISingleResult<ClsBOEmprunt> SelectEmpruntEnCoursByUtilisateur([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_HistoriqueByUtilisateur]")]
        public ISingleResult<ClsBOEmprunt> SelectEmpruntHistoriqueByUtilisateur([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_SelectAllEmpruntEnCours]")]
        public ISingleResult<ClsBOEmprunt> SelectAllEmpruntEnCours()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_Emprunter]")]
        public ISingleResult<ClsBOEmprunt> Emprunter([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID,
                                                     [Parameter(Name = "@Exemplaire_ID", DbType = "int")] Int32 Exemplaire_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID, Exemplaire_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_Retour]")]
        public ISingleResult<ClsBOEmprunt> EmpruntRetour([Parameter(Name = "@Emprunt_ID", DbType = "int")] Int32 Emprunt_ID,
                                                         [Parameter(Name = "@Exemplaire_ID", DbType = "int")] Int32 Exemplaire_ID,
                                                         [Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Emprunt_ID, Exemplaire_ID, Lecteur_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_Retour_Admin]")]
        public ISingleResult<ClsBOEmprunt> EmpruntRetourAdmin([Parameter(Name = "@Emprunt_ID", DbType = "int")] Int32 Emprunt_ID,
                                                         [Parameter(Name = "@Exemplaire_ID", DbType = "int")] Int32 Exemplaire_ID,
                                                         [Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Emprunt_ID, Exemplaire_ID, Lecteur_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Stat_SelectPrixByLecteur]")]
        public ISingleResult<ClsBOEmprunt> SelectPrixByLecteur([Parameter(Name = "@Lecteur_ID", DbType = "int")] Int32 Lecteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Lecteur_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Stat_SelectPrixByBiblio]")]
        public ISingleResult<ClsBOEmprunt> SelectPrixByBiblio([Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Biblio_ID);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Emprunt_NbrExemplaireByISBN]")]
        public ISingleResult<ClsBOEmprunt> CountNbrExemplaireByISBN([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN);
            return ((ISingleResult<ClsBOEmprunt>)(result.ReturnValue));
        }
    }
}

using System;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using COUCHEBO;
using System.Reflection;

namespace COUCHEDAL
{
    public class ClsDALLivre : DataContext
    {
        private static readonly MappingSource mappingSource = new AttributeMappingSource();

        public ClsDALLivre(string Connection) :
            base(Connection, mappingSource)
        { 
        }

        [Function(Name = "[dbo].[Livre_SelectAll]")]
        public ISingleResult<ClsBOLivre> SelectAllLivre()
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()));
            return ((ISingleResult<ClsBOLivre>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Livre_SelectByTitre]")]
        public ISingleResult<ClsBOLivre> SelectLivreByTitre([Parameter(Name = "@Titre", DbType = "varchar(100)")] String Titre)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), Titre);
            return ((ISingleResult<ClsBOLivre>)(result.ReturnValue));
        }

        [Function(Name = "[dbo].[Livre_SelectByISBN]")]
        public ISingleResult<ClsBOLivre> SelectLivreByISBN([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN);
            return ((ISingleResult<ClsBOLivre>)(result.ReturnValue));
        }
        

        [Function(Name = "[dbo].[Livre_Add]")]
        public ISingleResult<ClsBOLivre> AddLivre([Parameter(Name = "@ISBN", DbType = "varchar(13)")] String ISBN, 
                                                  [Parameter(Name = "@Titre", DbType = "varchar(100)")] String Titre,
                                                  [Parameter(Name = "@Genre_ID", DbType = "int")] Int32 Genre_ID,
                                                  [Parameter(Name = "@Cover", DbType = "varbinary(MAX)")] byte[] Cover,
                                                  [Parameter(Name = "@Biblio_ID", DbType = "int")] Int32 Biblio_ID,
                                                  [Parameter(Name = "@Auteur_ID", DbType = "int")] Int32 Auteur_ID)
        {
            var result = this.ExecuteMethodCall(this, ((MethodInfo)MethodInfo.GetCurrentMethod()), ISBN, Titre, Genre_ID, Cover, Biblio_ID, Auteur_ID);
            return ((ISingleResult<ClsBOLivre>)(result.ReturnValue));
        }
    }
}

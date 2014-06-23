using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLLivre_Auteur
    {
        public static List<ClsBOLivre_Auteur> SelectAllLivreAuteur()
        {
            List<ClsBOLivre_Auteur> lstRetour;

            using (var dal = new ClsDALLivre_Auteur(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllLivreAuteur().ToList();
            return lstRetour;
        }
    }
}

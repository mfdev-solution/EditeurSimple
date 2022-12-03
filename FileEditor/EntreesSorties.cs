using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace EditeurFichier
{
    internal class EntreesSorties
    {

        public static string LireTexte(string nomFichier)
        {    
            return File.ReadAllText(nomFichier);

        }

        public static void ecrireText(string nomFichier , string contenuFichier)
        {
            File.WriteAllText(nomFichier, contenuFichier);
        }

        public static string FiltrerTexte(string nomFichier)
        {
            StringBuilder contenuFichier = new StringBuilder();
            int codeCaractere = 0;
            StreamReader fluxFichier = new StreamReader(nomFichier);
            while ((codeCaractere = fluxFichier.Read()) != -1)
            {
               // Console.WriteLine((char)codeCaractere);
               // char c = (char)fluxFichier.Read();
               //contenuFichier.Append((codeCaractere);
               //First methode
                switch(codeCaractere)
                {
                    case (int)'"':contenuFichier.Append("&quot; ");break;
                    case (int)'&':contenuFichier.Append("&amp;");break;
                    case (int)'\'': contenuFichier.Append("&apos;"); break;
                    case (int)'<': contenuFichier.Append("&lt;"); break;
                    case (int)'>': contenuFichier.Append("&gt;"); break;
                    case (int)'{': contenuFichier.Append("&acg"); break;
                    case (int)'}': contenuFichier.Append("&acd"); break;
                    case (int)'$': contenuFichier.Append("&dol;"); break;
                    case (int)'(': contenuFichier.Append("parg;"); break;
                    case (int)')': contenuFichier.Append("pard;"); break;
                    default:contenuFichier.Append((char)codeCaractere);break;
                }
                /*
                 * Second methode
                 * switch (codeCaractere)
                {
                    case 34: contenuFichier.Append("&quot; "); break;
                    case 38: contenuFichier.Append("&amp;"); break;
                    case 39: contenuFichier.Append("&apos;"); break;
                    case 60: contenuFichier.Append("&lt;"); break;
                    case 62: contenuFichier.Append("&gt;"); break;
                    case 123: contenuFichier.Append("&acg"); break;
                    case 125: contenuFichier.Append("&acd"); break;
                    case 36: contenuFichier.Append("&dol;"); break;
                    case 40: contenuFichier.Append("parg;"); break;
                    case 41: contenuFichier.Append("pard;"); break;
                    default: contenuFichier.Append((char)codeCaractere); break;
                }
                 */

            }
            return contenuFichier.ToString();
        }


    }
}

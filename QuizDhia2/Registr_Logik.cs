using QuizSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDhia2
{
    internal class Registr_Logik
    {
        Benutzer benutzer = new Benutzer();

        public String benutzerName()
        {
            String benutzerName = benutzer.getBenutzer();
            return benutzerName;
        }
        
    }
}

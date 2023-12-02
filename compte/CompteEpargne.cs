using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptebancaire.compte;
public class CompteEpargne : CompteBancaire
{
    public CompteEpargne(string nom, string numeroCompte) : base(nom, numeroCompte)
    {
        this.tauxInteret = 4.6;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptebancaire;
public abstract class CompteBancaire
{
    protected string nom;
    protected double solde;
    protected string numeroCompte;
    protected double tauxInteret;

    public CompteBancaire(string nom, string numeroCompte)
    {
        this.nom = nom;
        this.numeroCompte = numeroCompte;
    }

    public string getNom() {
        return nom;
    }

    public string getNumeroCompte()
    {
        return numeroCompte;
    }

    public double consulterSolde()
    {
        return solde;
    }
    public void debiter(double somme)
    {
        this.solde += somme;
    }

    public void crediter(double somme)
    {
        this.solde -= somme;
    }

    public double taux_interet()
    {
        return tauxInteret;
    }
}

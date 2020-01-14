using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    public class Client
    {
        private float argent;
        private string nom;

        public float Argent { get => argent; set => argent = value; }
        public string Nom { get => nom; set => nom = value; }

        public Client()
        {
            Nom = "Dupont";
            Argent = 0f;
        }
        public Client(float nbArgent,string nom)
        {
            Argent = nbArgent;
            Nom = nom;
        }
        public void Virement_autre_client(Client client,float somme)
        {
            if (this.Argent < somme)
            {
                throw new Exception("Virement impossible, compte bancaire pas asser fournit");
            }
            if (somme < 0)
            {
                throw new Exception("Virement impossible avec une somme negative");
            }
            else
            {
                client.Recevoir_argent(somme);
                this.Perdre_argent(somme);
            }
        }
        public void Recevoir_argent(float somme)
        {
            if (somme < 0)
            {
                throw new Exception("Impossible de recevoir de l'argent négatif");
            }
            else
                Argent += somme;
        }
        public void Perdre_argent(float somme)
        {
            if (somme < 0)
            {
                throw new Exception("Impossible de perdre de l'argent négatif");
            }
            if(Argent-somme < 0)
            {
                throw new Exception("On ne peut avoir de compte en banque negatif");
            }
            else
            {
                Argent -= somme;
            }
            
        }

        public override string ToString()
        {
            return "Le client "+Nom+" détient :"+Argent+" Euros";
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                Client p = (Client)obj;
                return (p.Nom == Nom) && (p.Argent == Argent);
            }
            
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(argent, nom, Argent, Nom);
        }
    }
}

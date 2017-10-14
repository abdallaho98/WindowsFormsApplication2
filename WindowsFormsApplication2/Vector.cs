using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WindowsFormsApplication2
{
    public class Vector 
    {
        public Int32 taille;
        public List<double> Vecteur;
        public Vector() { this.taille = 0; this.Vecteur =new List<double>() ; }

        public void initiate(string text) 
        {

            if (text == "")
            { throw new VectorNullException("Vector Null"); }
            else
            {
                this.Vecteur = new List<double>();
                this.taille = 0;
                int m = text.Length, i = 0;
                string num = "";
                while (i < m)
                {
                    
                    if (text[i] == ' ')
                    {   
                        if (i != 0) { this.Vecteur.Add(Convert.ToDouble(num)); num = "" ; }
                        while (text[i] == ' ') { i++;if (i == m) break; }
                    }
                    else { num += text[i];i++; }
                }
                if (num != "") { this.Vecteur.Add(Convert.ToDouble(num)); }
                taille = this.Vecteur.Count;
            }
        }

        public void TriezVector()
        {
            double[] table = this.Vecteur.ToArray();
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille - i -1; j++)
                {
                    if (table[j] < table[j + 1])
                    {
                        double temp = table[j];
                        table[j] = table[j+1];
                        table[j + 1] = temp;
                    }
                }
            }
            this.Vecteur = table.ToList();
        }

        public Vector Sommet(Vector v) 
        {
            Vector som = new Vector();
            
            if (this.taille != v.taille)
            {
                throw new TailleDefferentException("Taille Défferante on peut pas faire l'addition");
            }
            else
            { som.taille = this.taille;
                for (int i = 0; i != taille; i++)
                {
                    som.Vecteur.Insert(i, this.Vecteur.ElementAt(i) + v.Vecteur.ElementAt(i));
                }
            }
            return som;
        }

        public string ToString()
        {
            string tex = "";
            foreach(double num in Vecteur)
            { 
               tex += num+ " ";
            }
            return tex;
        }
        public void Inverse()
        {
            for (int i = 0; i < taille; i++)
            {
                this.Vecteur.Insert(i, this.Vecteur.LastOrDefault());
                this.Vecteur.RemoveRange(taille, 1);
            }
        }

        public Vector Application(string operation,double Number)
        {
            Vector a = new Vector();
            a.taille = this.taille;
            if (operation == "+")
            {
                for (int i = 0; i < this.Vecteur.Count; i++)
                {
                    a.Vecteur.Add(this.Vecteur.ElementAt(i) + Number);
                }
            }
            else if
                (operation == "-")
            {
                for (int i = 0; i < this.Vecteur.Count; i++)
                {
                    a.Vecteur.Add(this.Vecteur.ElementAt(i) - Number);
                }
            }
            else if (operation == "*")
            {
                for (int i = 0; i < this.Vecteur.Count; i++)
                {
                    a.Vecteur.Add(this.Vecteur.ElementAt(i) * Number);
                }
            }
            else if (operation == "/")
            {
                if (Number == 0)
                {
                    throw new DivideByZeroException("Devision par 0");
                }
                else
                {
                    for (int i = 0; i < this.Vecteur.Count; i++)
                    {
                        a.Vecteur.Add(this.Vecteur.ElementAt(i) / Number);
                    }
                }
            }
            
            return a;
        }

        public double Max()
        {
            double max = 0;
            for (int i=0;i < taille; i++)
            {
                if (max < this.Vecteur.ElementAt(i))
                {
                    max = this.Vecteur.ElementAt(i);
                }
            }

            return max;
        }

        public double Min()
        {
            double min = 0;
            for (int i = 0; i < taille; i++)
            {
                if (min > this.Vecteur.ElementAt(i))
                {
                    min = this.Vecteur.ElementAt(i);
                }
            }

            return min;
        }
    }
}

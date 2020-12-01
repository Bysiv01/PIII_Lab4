using System;
using System.Collections.Generic;
using System.Text;

    public class Ksiazka
    {
        public string Tytul;
        public string Autor;

        public int NrRegalu = 0;
        public int NrPolki = 0;
        public int NrMiejscaNaPolce = 0;


        public Ksiazka(string tytul, string autor, int nrRegalu, int nrPolki, int nrMiejscaNaPolce)
        {
            Tytul = tytul;
            Autor = autor;
            NrRegalu = nrRegalu;
            NrPolki = nrPolki;
            NrMiejscaNaPolce = nrMiejscaNaPolce;
        }

    }


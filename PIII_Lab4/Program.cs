using System;

namespace PIII_Lab4
{


    class Program
    {

        static void automatycznie_wypelnienie(Ksiazka[,,] Regal)
        {
            Ksiazka ksiazka = new Ksiazka("test", "test", 1, 1, 1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Regal[i, j, k] = ksiazka;
                    }
                }
            }

            Ksiazka a = new Ksiazka("dziady", "Adam Mickiewicz", 2, 1, 3);

            Regal[2, 1, 3] = a;

        }

        static void szukanie(Ksiazka[,,] Regal, string sprawdzanie)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {

                        if (Regal[i, j, k].Autor.Contains(sprawdzanie, StringComparison.OrdinalIgnoreCase) || Regal[i, j, k].Tytul.Contains(sprawdzanie, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Twoja książka znajduje się na półce: {Regal[i, j, k].NrPolki}, w regale: {Regal[i, j, k].NrRegalu} na miejscu: {Regal[i, j, k].NrMiejscaNaPolce}");
                            return;
                        }

                    }

                }
            }
            Console.WriteLine("nie można znaleźć książki");
        }

        static void Main(string[] args)
        {

            Ksiazka[,,] Regal = new Ksiazka[3, 6, 10];

            automatycznie_wypelnienie(Regal);

            Console.WriteLine("Wpisz tytul lub autora szukanej książki ");
            string sprawdzenie = Console.ReadLine();

            szukanie(Regal, sprawdzenie);
        }
    }
}
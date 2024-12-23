using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Precizari:

1. Toate problemele se vor rezolva in C#. 
2. Toate valorile se vor citi de la tastatura. 
3. Rezultatele se vor afisa pe ecran (in consola). 
4. Solutiile se vor pune intr-un repo pe GitHub

1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. 
2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
4. Detreminati daca un an y este an bisect. 
5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
9. Afisati toti divizorii numarului n. 
10. Test de primalitate: determinati daca un numar n este prim.
11. Afisati in ordine inversa cifrele unui numar n. 
12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
13. Determianti cati ani bisecti sunt intre anii y1 si y2.
14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13 / 30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
    O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n sunt mai mari sau egale decat 0
    O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
    O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". */


namespace exercitiiFP
{
    class Program
    {
        static void Main(string[] args)
        {
            int program;
            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n Probleme rezolvate: 1 - 20 (Setul I)");
                    Console.Write(" Introduceti numarul problemei a carui program doriti sa il rulati: ");
                    program = int.Parse(Console.ReadLine());
                    if (program < 1 || program > 21)
                    {
                        Console.WriteLine("\n Pentru aceasta problema nu exista program.\n Incercati din nou!");
                    }
                    else 
                    {
                        switch (program)
                        {
                            case 1:
                                P1();
                                break;
                            case 2:
                                P2();
                                break;
                            case 3:
                                P3();
                                break;
                            case 4:
                                P4();
                                break;
                            case 5:
                                P5();
                                break;
                            case 6:
                                P6();
                                break;
                            case 7:
                                P7();
                                break;
                            case 8:
                                P8();
                                break;
                            case 9:
                                P9();
                                break;
                            case 10:
                                P10();
                                break;
                            case 11:
                                P11();
                                break;
                            case 12:
                                P12();
                                break;
                            case 13:
                                P13();
                                break;
                            case 14:
                                P14();
                                break;
                            case 15:
                                P15();
                                break;
                            case 16:
                                P16();
                                break;
                            case 17:
                                P17();
                                break;
                            case 18:
                                P18();
                                break;
                            case 19:
                                P19();
                                break;
                            case 20:
                                P20();
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }
        }








        //                                                               R E Z O L V A R I 







        //###################################################################    1    ##################################################################

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void P1()
        {
            string rezumat = "Programul rezolva o ecuatie de gradul 1 de felul ax + b = 0.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0, x = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar pentru variabila a: ");
                    a = double.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("\n Nu exista solutie pentru valoarea introdusa in a.\n\n Incercati din nou!");
                    }
                    else
                    {
                        Console.Write(" Introduceti un numar pentru variabila b: ");
                        b = double.Parse(Console.ReadLine());
                        x = -b / a;
                        retry = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            Console.WriteLine($" Valoarea variabilei x este {x}");
        }




        //###################################################################    2    ################################################################## 




        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        /// </summary>
        private static void P2()
        {
            string rezumat = "Programul rezolva o ecuatie de gradul 2 cu o necunoscuta de felul ax ^ 2 + bx + c = 0";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a, b, c, x, x2;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar pentru variabila a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar pentru variabila b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar pentru variabila c: ");
                    c = double.Parse(Console.ReadLine());

                    double delta = b * b - 4 * a * c;

                    if(delta < 0)
                    {
                        Console.WriteLine("\n Nu exista solutie pentru valorile introduse.\n\n Incercati din nou!");
                    }
                    if (delta == 0)
                    {
                        x = -b / 2 * a;
                        Console.WriteLine($"\n Valoarea variabilei x este {x}.");
                        retry = false;
                    }
                    else if (delta > 0)
                    {
                        x = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine($"\n Valoarea variabilei x poate fi {x} sau {x2}.");
                        retry = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }
        }




        //###################################################################    3    ################################################################## 




        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        private static void P3()
        {
            string rezumat = "Programul determina daca un numar intreg n se divide cu un altul k.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n, k;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar intreg pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar intreg pentru k: ");
                    k = int.Parse(Console.ReadLine());

                    if (n % k == 0)
                    {
                        Console.WriteLine($"\n Numarul {n} se divide cu numarul {k}.");
                    }
                    else
                    {
                        Console.WriteLine($"\n Numarul {n} nu se divide cu numarul {k}.");
                    }
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
        }




        //###################################################################    4    ################################################################## 




        /// <summary>
        /// Detreminati daca un an y este an bisect.
        /// </summary>
        private static void P4()
        {
            string rezumat = "Programul determina daca un an y este an bisect.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int y = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un an: ");
                    y = int.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
            

            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine($"\n Anul {y} este an bisect.");
            }
            else
            {
                Console.WriteLine($"\n Anul {y} nu este an bisect.");
            }
        }

                                                           


        //###################################################################    5    ################################################################## 




        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
        /// </summary>
        private static void P5()
        {
            string rezumat = "Programul extrage si afiseaza a k-a cifra de la sfarsitul unui numar intreg.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0, k = 0, cifrak = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar intreg: ");
                    n = int.Parse(Console.ReadLine());
                    string numar = Convert.ToString(n);
                    Console.Write(" Introduceti un numar natural pentru k: ");
                    k = int.Parse(Console.ReadLine());

                    if (k <= numar.Length && k > 0)
                    {
                        for (int i = 0; i < k; i++)
                        {
                            cifrak = n % 10;
                            n = n / 10;
                        }

                        if (n >= 0)
                        {
                            if (k == 1)
                            {
                                Console.WriteLine($"\n Prima cifra a numarului introdus (numarand de la dreapta spre stanga este) este {cifrak}.");
                                retry = false;
                            }
                            else
                            {
                                Console.WriteLine($"\n A {k}-a cifra a numarului introdus este {cifrak}.");
                                retry = false;
                            }
                        }
                        else
                        {
                            if (k == 1)
                            {
                                Console.WriteLine($"\n Prima cifra a numarului introdus (numarand de la dreapta spre stanga este) este {-cifrak}.");
                                retry = false;
                            }
                            else
                            {
                                Console.WriteLine($"\n A {k}-a cifra a numarului introdus este {-cifrak}.");
                                retry = false;
                            }
                        }
                    }
                    else if (k <= 0)
                    {
                        Console.WriteLine("\n Nu exista rezultat pentru valori mai mici decat 1.\n\n Incercati din nou!");
                    }
                    else
                    {
                        Console.WriteLine($"\n Numarul {n} nu are {k} cifre.\n\n Incercati din nou!");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
        }




        //###################################################################    6    ################################################################## 




        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void P6()
        {
            string rezumat = "Programul determina daca trei numere naturale a, b si c pot fi lungimile laturilor unui triunghi.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0, c = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar natural pentru a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar natural pentru b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar natural pentru c: ");
                    c = double.Parse(Console.ReadLine());
                    if (a < 1 || b < 1 || c < 1)
                    {
                        Console.WriteLine("\n Valorile introduse nu pot fi mai mici decat unu.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la 0 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine($"\n {a}, {b} si {c} pot fi lungimile laturilor unui triunghi.");
            }
            else
            {
                Console.WriteLine($"\n {a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi.");
            }
        }




        //###################################################################    7    ################################################################## 




        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        /// </summary>
        private static void P7()
        {
            string rezumat = "Programul inverseaza valorile a doua variabile numerice a si b date.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0, aux;
            char verif = '0';
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti o valoare numerica pentru a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("\n Introduceti o valoare numerica pentru b: ");
                    b = double.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            aux = a;
            a = b;
            b = aux;

            retry = true;
            while (retry)
            {
                try
                {
                    Console.Write("\n Valorile au fost inversate. Pentru verificare introduceti numele variabilei pe care doriti sa o afisati: ");
                    verif = char.Parse(Console.ReadLine());
                    if (verif != 'a' && verif != 'b')
                    {
                        Console.WriteLine($"\n Variabila {verif} nu exista.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita. Introduceti un singur caracter.\n\n Incercati din nou!");
                }
            }

            if (verif == 'a')
            {
                Console.WriteLine($"\n {a}");
            }
            else if (verif == 'b')
            {
                Console.WriteLine($"\n {b}");
            }
        }




        //###################################################################    8    ################################################################## 




        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 
        /// </summary>
        private static void P8()
        {
            string rezumat = "Programul inverseaza valorile a doua variabile numerice a si b date, fara a folosi alte variabile suplimentare.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0;
            char verif = '0';
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti o valoare numerica pentru a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("\n Introduceti o valoare numerica pentru b: ");
                    b = double.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            a = a + b;
            b = a - b;
            a = a - b;

            retry = true;
            while (retry)
            {
                try
                {
                    Console.Write("\n Valorile au fost inversate. Pentru verificare introduceti numele variabilei pe care doriti sa o afisati: ");
                    verif = char.Parse(Console.ReadLine());
                    if (verif != 'a' && verif != 'b')
                    {
                        Console.WriteLine($"\n Variabila {verif} nu exista.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita. Introduceti un singur caracter.\n\n Incercati din nou!");
                }
            }

            if (verif == 'a')
            {
                Console.WriteLine($"\n {a}");
            }
            else if (verif == 'b')
            {
                Console.WriteLine($"\n {b}");
            }
        }

    




        //###################################################################    9    ################################################################## 




        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void P9()
        {
            string rezumat = "Programul afiseaza toti divizorii unui numar intreg n.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar intreg: ");
                    n = int.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            if (n != 0)
            {
                Console.Write($"\n Divizorii lui {n} sunt: ");

                if (n > 0)
                {
                    for (int i = 1; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.Write($"{i}  {-i}  ");
                        }
                    }
                }
                else if (n < 0)
                {
                    for (int i = -1; i >= n / 2; i--)
                    {
                        if (n % i == 0)
                        {
                            Console.Write($"{i}  {-i}  ");
                        }
                    }
                }

                Console.Write($"{n}  {-n}");
            }
            else
            {
                Console.WriteLine("\n 0 nu are nici un divizor.");
            }


        }




        //###################################################################    10    ################################################################## 




        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void P10()
        {
            string rezumat = "Programul determina daca un numar natural n este prim.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar natural: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("\n Valoarea introdusa nu poate fi mai mica decat 0.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la 0 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            if (EstePrim(n))
            {
                Console.WriteLine($"\n Numarul {n} este prim.");
            }
            else
            {
                Console.WriteLine($"\n Numarul {n} nu este prim.");
            }
        }

        private static bool EstePrim(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= n ; i = i + 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }




        //###################################################################    11    ################################################################## 




        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void P11()
        {
            string rezumat = "Programul afiseaza in ordine inversa cifrele unui numar intreg n.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0, cifra, result = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar intreg: ");
                    n = int.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            int dublura_n = n;

            if (dublura_n > 0)
            {
                while (n > 0)
                {
                    cifra = n % 10;
                    n = n / 10;
                    result = result * 10 + cifra;
                }
            }
            else if (dublura_n < 0)
            {
                while (n < 0)
                {
                    cifra = n % 10;
                    n = n / 10;
                    result = (result * 10 + cifra);
                }
            }

            if (dublura_n > 0)
            {
                Console.WriteLine($"\n {result}");
            }
            else if (dublura_n < 0)
            {
                Console.WriteLine($"\n {-result}");
            }
            else
            {
                Console.WriteLine($"\n {n}");
            }
        }




        //###################################################################    12    ################################################################## 




        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void P12()
        {
            string rezumat = "Programul determina cate numere integi divizibile cu n se afla in intervalul [a, b].";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int a = 0, b = 0, n = 0, result = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar intreg pentru a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar intreg pentru b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar intreg pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        Console.WriteLine($"\n EROARE!!! Impartirea la zero nu are solutii.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
           
            if (b >= a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % n == 0)
                    {
                        result = result + 1;
                    }
                }
            }
            else
            {
                for (int i = a; i >= b; i--)
                {
                    if (i % n == 0)
                    {
                        result = result + 1;
                    }
                }
            }

            if (result == 1)
            {
                Console.WriteLine($"\n Exista un singur numar divizibil cu {n} in intervalul [{a} - {b}].");
            }
            else
            {
                Console.WriteLine($"\n Exista {result} numere divizibile cu {n} in intervalul [{a} - {b}].");
            }
        }




        //###################################################################    13    ################################################################## 




        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            string rezumat = "Programul determina cati ani bisecti sunt intre anii y1 si y2.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int y1 = 0, y2 = 0, contor = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un an pentru y1: ");
                    y1 = int.Parse(Console.ReadLine());
                    Console.Write("\n Introduceti un an pentru y2: ");
                    y2 = int.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la {int.MinValue} pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            if (y2 >= y1)
            {
                for (int i = y1 + 1; i < y2; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    {
                        contor++;
                    }
                }
            }
            else
            {
                for (int i = y1 - 1; i > y2; i--)
                {
                    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    {
                        contor++;
                    }
                }
            }
          
            if (contor == 0)
            {
                Console.WriteLine($"\n Nu exista nici un an bisect intre anii {y1} si {y2}.");
            }
            else if (contor == 1)
            {
                Console.WriteLine($"\n Intre anii {y1} si {y2}, exista un singur an bisect.");
            }
            else
            {
                Console.WriteLine($"\n Intre anii {y1} si {y2}, exista {contor} ani bisecti.");
            }
        }




        //###################################################################    14    ################################################################## 




        /// <summary>
        /// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        /// </summary>
        private static void P14()
        {
            string rezumat = "Programul determina daca un numar natural n este palindrom.";
            
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar natural: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("\n Valoarea introdusa nu poate fi mai mica decat zero.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la 0 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            if (n.IsPalindrome())
            {
                Console.WriteLine($"\n Numarul {n} este palindrom.");
            }
            else
            {
                Console.WriteLine($"\n Numarul {n} nu este palindrom.");
            }
        }




        //###################################################################    15    ################################################################## 




        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void P15()
        {
            string rezumat = "Programul afiseaza in ordine crescatoare 3 numere date.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0, c = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.WriteLine("\n\n Introduceti 3 numere, cate unul pe o linie:");

                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    c = double.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            if (a > c)
            {
                (a, c) = (c, a);
            }
            else if (a > b)
            {
                (a, b) = (b, a);
            }

            if (b > c)
            {
                (b, c) = (c, b);
            }
            Console.WriteLine($"\n Numerele introduse, afisate in ordine crescatoare: {a}  {b}  {c}");
        }




        //###################################################################    16    ################################################################## 




        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri).
        /// </summary>
        private static void P16()
        {
            string rezumat = "Programul afiseaza in ordine crescatoare 5 numere date.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            double a = 0, b = 0, c = 0, d = 0, e = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.WriteLine("\n\n Introduceti 5 numere, cate unul pe o linie:");

                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    c = double.Parse(Console.ReadLine());
                    d = double.Parse(Console.ReadLine());
                    e = double.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            if (a > e)
            {
                (a, e) = (e, a);
            }
            if (a > d)
            {
                (a, d) = (d, a);
            }
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (a > b)
            {
                (a, b) = (b, a);
            }
            
            if (b > e)
            {
                (b, e) = (e, b);
            }
            if (b > d)
            {
                (b, d) = (d, b);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }
            
            if (c > e)
            {
                (c, e) = (e, c);
            }
            if (c > d)
            {
                (c, d) = (d, c);
            }

            if (d > e)
            {
                (d, e) = (e, d);
            }
            Console.WriteLine($"\n Numerele introduse, afisate in ordine crescatoare: {a}  {b}  {c}  {d}  {e}");

        }




        //###################################################################    17    ################################################################## 




        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
        /// </summary>
        private static void P17()
        {
            string rezumat = "Programul determina cel mai mare divizor comun si cel mai mic multiplu comun a doua numere naturale diferite de zero,";
            string rezumat2 = "folosind metoda lui Euclid.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            Console.Write(rezumat2);
            for (int i = 0; i < rezumat.Length - rezumat2.Length + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|\n");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int a = 0, b = 0, cmmdc, cmmmc, ab;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti primul numar: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\n Introduceti al doilea numar: ");
                    b = int.Parse(Console.ReadLine());
                    if (a < 1 || b < 1)
                    {
                        Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mica." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            ab = a * b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            cmmdc = a;

            cmmmc = ab / cmmdc;

            Console.WriteLine($"\n Cel mai mare divizor comun: {cmmdc}\n Cel mai mic multiplu comun: {cmmmc}");

        }




        //###################################################################    18    ################################################################## 




        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>
        private static void P18()
        {
            string rezumat = "Programul afiseaza descompunerea in factori primi ai unui numar natural n.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0, prim = 2, exponent;
            string rezultat = "";
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar natural: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 1)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            while (n > 1)
            {
                exponent = 0;

                while (n % prim == 0)
                {
                    exponent++;
                    n = n / prim;
                }

                if (exponent > 0)
                {
                    rezultat = rezultat + ($"  {prim}^{exponent}  x");
                }

                prim++;

                if (n > 1 && prim * prim > n)
                {
                    prim = n;
                }
            }

            Console.Write(rezultat.Remove(rezultat.LastIndexOf("x")));
        }




        //###################################################################    19    ################################################################## 




        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        private static void P19()
        {
            string rezumat = "Programul determina daca un numar natural e format doar cu 2 cifre care se pot repeta.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int nr = 0;
            string n = "";
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar natural: "); // 8588565
                    nr = int.Parse(Console.ReadLine());
                    n = nr.ToString();
                    if (nr < 1)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
            
            List<char> cifre = new List<char>();

            foreach (var c in n)
            {
                if (!cifre.Contains(c))
                {
                    cifre.Add(c);
                }
            }

            if (cifre.Count == 2)
            {
                Console.WriteLine("  Numarul introdus este format doar din doua cifre (care se pot repeta).");
            } 
            else
            {
                Console.WriteLine("  Numarul introdus NU este format doar din doua cifre (care se pot repeta).");
            }
        }




        //###################################################################    20    ################################################################## 




        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13 / 30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
        /// O fractie este neperiodica daca numitorul este de forma 2 ^ m* 5 ^ n unde m si n sunt mai mari sau egale decat 0
        /// O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
        /// O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
        /// </summary>
        private static void P20()
        {
            string rezumat = "Programul afisaza fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");
           
            int m = 0, n = 0;
            bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("\n\n Introduceti un numar pentru m: ");
                    m = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }
            
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"  {parteInt}.");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }




        //###################################################################    21    ################################################################## 




        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
        /// </summary>
        private static void P21()
        {
            string rezumat = "Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\".";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

        }
    }
}




































/*double a = 0, b = 0, c = 0;

            Console.WriteLine("Programul afiseaza 3 numere date, in ordine crescatoare.");

            Console.WriteLine("Introduceti 3 numere, cate unul pe o linie:");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a > c)
            {
                double aux = a;
                a = c;
                c = aux;
            }

            if (a > b)
            {
                double aux = a;
                a = b;
                b = aux;
            }

            if (b > c)
            {
                double aux = b;
                b = c;
                c = aux;
            }

            Console.WriteLine($"\n {a}  {b}  {c}");
 
 
 
 
 */
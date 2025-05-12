using System.Threading;
using System.Diagnostics;

namespace Threads_Tasks
{
    internal class Program
    {
        public static object xopa1 = new object();
        public static object xopa2 = new object();
        public static object xopa3 = new object();
        public static object xopa4 = new object();
        public static object xopa5 = new object();

        public static readonly object consolaLock = new object();

        public static void Main(string[] args)
        {       
            Thread comensal1 = new Thread(new ThreadStart(CicloVida1));//DarkGray
            Thread comensal2 = new Thread(new ThreadStart(CicloVida2));//Cyan
            Thread comensal3 = new Thread(new ThreadStart(CicloVida3));//Verde
            Thread comensal4 = new Thread(new ThreadStart(CicloVida4));//Amarillo
            Thread comensal5 = new Thread(new ThreadStart(CicloVida5));//DarkRed

            comensal1.Start();
            comensal2.Start();
            comensal3.Start();
            comensal4.Start();
            comensal5.Start();                      
        }

        static void CicloVida1()
        {
            TimeSpan duracion = TimeSpan.FromSeconds(30); // duración deseada
            Stopwatch reloj = Stopwatch.StartNew(); // mide el tiempo transcurrido    

            while (reloj.Elapsed < duracion)
            {                
                double pensant = Pensar();
                lock (consolaLock)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Comensal1 pensant: {pensant}");
                    Console.ResetColor();
                }
                Thread.Sleep((int)(pensant * 1000)); // Convertir a segons

                double menjant = Menja();

                bool fam = false;
                fam = true;
                while (fam)
                {
                    lock (consolaLock)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Comensal1 demana palets");
                        Console.ResetColor();
                    }
                    
                    if (!Monitor.IsEntered(xopa5) && !Monitor.IsEntered(xopa1))//Solo entra si x5 y x1 no estan bloqueados
                    {
                        lock (xopa5)
                        {
                            lock (xopa1)
                            {
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine($"Comensal1 menjant: {menjant}");
                                    Console.ResetColor();
                                }                                
                                Thread.Sleep((int)(menjant * 1000)); // Convertir a segons
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Comensal1 deixa palets");
                                    Console.ResetColor();
                                }                                
                            }
                        }

                        fam = false;                        
                    }

                    else
                    {
                        lock (consolaLock)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Comensal1: no hi ha palets");
                            Console.ResetColor();
                        }                        
                        Cronometro();
                        Thread.Sleep(1000);//espera 1seg 
                    }
                }
            }            
        }

        static void CicloVida2()
        {
            TimeSpan duracion = TimeSpan.FromSeconds(30); // duración deseada
            Stopwatch reloj = Stopwatch.StartNew(); // mide el tiempo transcurrido    

            while (reloj.Elapsed < duracion)
            {                
                double pensant = Pensar();
                lock (consolaLock)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Comensal2 pensant: {pensant}");
                    Console.ResetColor();
                }                
                Thread.Sleep((int)(pensant * 1000)); // Convertir a segons

                double menjant = Menja();

                bool fam = false;
                fam = true;
                while (fam)
                {
                    lock (consolaLock)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Comensal2 demana palets");
                        Console.ResetColor();
                    }
                    
                    if (!Monitor.IsEntered(xopa1) && !Monitor.IsEntered(xopa2))
                    {
                        lock (xopa1)
                        {
                            lock (xopa2)
                            {
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Comensal2 menjant: {menjant}");
                                    Console.ResetColor();
                                }                                
                                Thread.Sleep((int)(menjant * 1000)); // Convertir a segons
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Comensal2 deixa palets");
                                    Console.ResetColor();
                                }                                
                            }
                        }

                        fam = false;                        
                    }

                    else
                    {
                        lock (consolaLock)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Comensal2: no hi ha palets");
                            Console.ResetColor();
                        }                        
                        Cronometro();
                        Thread.Sleep(1000);//espera 1seg 
                    }
                }
            }                
        }

        static void CicloVida3()
        {
            TimeSpan duracion = TimeSpan.FromSeconds(30); // duración deseada
            Stopwatch reloj = Stopwatch.StartNew(); // mide el tiempo transcurrido    

            while (reloj.Elapsed < duracion)
            {                
                double pensant = Pensar();
                lock (consolaLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Comensal3 pensant: {pensant}");
                    Console.ResetColor();
                }                
                Thread.Sleep((int)(pensant * 1000)); // Convertir a segons

                double menjant = Menja();

                bool fam = false;
                fam = true;
                while (fam)
                {
                    lock (consolaLock)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Comensal3 demana palets");
                        Console.ResetColor();
                    }
                    
                    if (!Monitor.IsEntered(xopa2) && !Monitor.IsEntered(xopa3))
                    {
                        lock (xopa2)
                        {
                            lock (xopa3)
                            {
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Comensal3 menjant: {menjant}");
                                    Console.ResetColor();
                                }                                
                                Thread.Sleep((int)(menjant * 1000)); // Convertir a segons
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Comensal3 deixa palets");
                                    Console.ResetColor();
                                }                                
                            }
                        }

                        fam = false;                        
                    }

                    else
                    {
                        lock (consolaLock)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Comensal3: no hi ha palets");
                            Console.ResetColor();
                        }                        
                        Cronometro();
                        Thread.Sleep(1000);//espera 1seg 
                    }
                }
            }                
        }

        static void CicloVida4()
        {
            TimeSpan duracion = TimeSpan.FromSeconds(30); // duración deseada
            Stopwatch reloj = Stopwatch.StartNew(); // mide el tiempo transcurrido    

            while (reloj.Elapsed < duracion)
            {                
                double pensant = Pensar();
                lock (consolaLock)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Comensal4 pensant: {pensant}");
                    Console.ResetColor();
                }
                Thread.Sleep((int)(pensant * 1000)); // Convertir a segons

                double menjant = Menja();

                bool fam = false;
                fam = true;
                while (fam)
                {
                    lock (consolaLock)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Comensal4 demana palets");
                        Console.ResetColor();
                    }
                    
                    if (!Monitor.IsEntered(xopa3) && !Monitor.IsEntered(xopa4))
                    {
                        lock (xopa3)
                        {
                            lock (xopa4)
                            {
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"Comensal4 menjant: {menjant}");
                                    Console.ResetColor();
                                }                                
                                Thread.Sleep((int)(menjant * 1000)); // Convertir a segons
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Comensal4 deixa palets");
                                    Console.ResetColor();
                                }                                
                            }
                        }

                        fam = false;                        
                    }

                    else
                    {
                        lock (consolaLock)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Comensal4: no hi ha palets");
                            Console.ResetColor();
                        }                        
                        Cronometro();
                        Thread.Sleep(1000);//espera 1seg 
                    }
                }
            }                
        }

        static void CicloVida5()
        {
            TimeSpan duracion = TimeSpan.FromSeconds(30); // duración deseada
            Stopwatch reloj = Stopwatch.StartNew(); // mide el tiempo transcurrido    

            while (reloj.Elapsed < duracion)
            {
                
                double pensant = Pensar();
                lock (consolaLock)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Comensal5 pensant: {pensant}");
                    Console.ResetColor();
                }                
                Thread.Sleep((int)(pensant * 1000)); // Convertir a segons

                double menjant = Menja();

                bool fam = false;
                fam = true;
                while (fam)
                {
                    lock (consolaLock)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Comensal5 demana palets");
                        Console.ResetColor();
                    }
                    
                    if (!Monitor.IsEntered(xopa4) && !Monitor.IsEntered(xopa5))
                    {
                        lock (xopa4)
                        {
                            lock (xopa5)
                            {
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Comensal5 menjant: {menjant}");
                                    Console.ResetColor();
                                }
                                Thread.Sleep((int)(menjant * 1000)); // Convertir a segons
                                lock (consolaLock)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Comensal5 deixa palets");
                                    Console.ResetColor();
                                }
                            }
                        }

                        fam = false;                        
                    }

                    else
                    {
                        lock (consolaLock)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Comensal5: no hi ha palets");
                            Console.ResetColor();
                        }
                        Cronometro();
                        Thread.Sleep(1000);//espera 1seg 
                    }
                }
            }                
        }

        private static double Pensar()
        {
            Random pensa = new Random();//Crea un objecte Random
            double min = 0.5;
            double max = 2.0;
            // Generar un número aleatorio entre min y max
            int precision = 1000; // para 3 decimales
            int minInt = (int)(min * precision);
            int maxInt = (int)(max * precision);

            int value = pensa.Next(minInt, maxInt + 1); // incluye el tope
            double pensant = (double)value / precision;
            return pensant;
        }
        
        private static double Menja()
        {
            Random menja = new Random();//Crea un objecte Random
            double min2 = 0.5;
            double max2 = 1;
            // Generar un número aleatorio entre min y max
            int precision2 = 1000; // para 3 decimales
            int minInt2 = (int)(min2 * precision2);
            int maxInt2 = (int)(max2 * precision2);

            int value2 = menja.Next(minInt2, maxInt2 + 1); // incluye el tope
            double menjant = (double)value2 / precision2;
            return menjant;
        }

        private static void Cronometro()
        {
            Console.WriteLine("Empieza el cronometro");
        }
    }
}
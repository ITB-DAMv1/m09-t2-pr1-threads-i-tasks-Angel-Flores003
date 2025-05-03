[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/xs3aclQL)

📎Si pongo lo siguiente en visual studio: 

📎Random pensa = new Random();

📎double min = 0.5;

📎double max = 2.0;

📎double pensant = pensa.NextDouble() * (max - min) + min;  

📎Cuanto es el rango del random?

> Por lo tanto, el rango del número aleatorio (pensant) es [0.5, 2.0), es decir:

> Incluye 0.5

> No incluye 2.0

> Si necesitas incluir exactamente 2.0, tendrías que ajustar la fórmula o el método. ¿Te gustaría que te muestre cómo hacerlo?

📎si porfa

> Si te basta con una precisión fija, como por ejemplo 3 decimales, puedes hacer esto:

> int precision = 1000; // para 3 decimales

> int minInt = (int)(min * precision);

> int maxInt = (int)(max * precision);

> int value = pensa.Next(minInt, maxInt + 1); // incluye el tope

> double pensant = (double)value / precision;

-------------------------------------------------------------------------------

📎Como debloqueo xopa1 y xopa5?

📎lock (xopa1)

📎lock (xopa5) {

📎Console.WriteLine($"menjant: {menjant}");

📎Thread.Sleep((int)(menjant * 1000)); // Convertir a segons

📎Console.WriteLine("menja finalitzat"); }

📎fam = false;

📎lock (xopa1)

📎lock (xopa5) 

> Buena pregunta. En C#, cuando usas lock(obj), se adquiere un bloqueo sobre obj durante el bloque de código { ... }.

> Pero el desbloqueo ocurre automáticamente cuando el flujo sale del lock—no necesitas desbloquearlo manualmente.

-------------------------------------------------------------------------------

📎Como hago que cada hilo tenga su propio color?

> Como los hilos se ejecutan en paralelo, puede que se mezclen las líneas en consola si escriben al mismo tiempo. Para evitarlo, puedes usar un lock alrededor de los Console.WriteLine, así:

> static readonly object consolaLock = new object();

> lock (consolaLock) { }

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

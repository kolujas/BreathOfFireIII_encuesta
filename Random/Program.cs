namespace BreathOfFireIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random dadosRnd = new Random();
            int dados = dadosRnd.Next(1,20);
            Console.WriteLine($"Tiraste los dados y sacaste: {dados}, aplicaste un porcentaje del {dados}%");*/

            // Nombre de la encuesta
            string tituloEncuesta = "Encuesta de Breath Of Fire III";

            // Muestro el titulo
            Console.WriteLine(tituloEncuesta);
            Console.WriteLine();
            Console.WriteLine();

            // Almaceno las preguntas en una lista
            List<string> preguntas = ["¿Nombre del personaje principal?", "¿Cómo se llama la ciudad de origen de Nina?", "¿Quién es Garr?", "¿Cuál es la transformación de dragón más fuerte del juego", "¿Cómo se separó el 'trío de ladrones' (Ryu, Rei y Teepo) luego de derrotar a McNeil"];

            
            int newGame = 0;

            while (newGame == 0) {

                int calificacionFinal = 0;
                // Primera pregunta
                string pregunta1 = preguntas[0];

                Console.WriteLine(pregunta1);
                Console.WriteLine();

                Console.WriteLine("1 - Cloud");
                Console.WriteLine("2 - Ryu");
                Console.WriteLine("3 - Fou-Lou");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Cloud'.");
                        calificacionFinal += 0;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Ryu'.");
                        calificacionFinal += 1;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Fou-Lou'.");
                        calificacionFinal += 0;
                        break;
                }

                Console.WriteLine(calificacionFinal);

                Console.WriteLine("--------------------------------------------");

                // Segunda pregunta

                string pregunta2 = preguntas[1];

                Console.WriteLine(pregunta2);
                Console.WriteLine();

                Console.WriteLine("1 - Raphala Region");
                Console.WriteLine("2 - Yrall Region");
                Console.WriteLine("3 - Wyndia");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Raphala Region'.");
                        calificacionFinal += 0;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Yrall Region'.");
                        calificacionFinal += 0;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Wyndia'.");
                        calificacionFinal += 1;
                        break;
                }

                Console.WriteLine(calificacionFinal);

                Console.WriteLine("--------------------------------------------");

                // Tercera pregunta

                string pregunta3 = preguntas[2];

                Console.WriteLine(pregunta3);
                Console.WriteLine();

                Console.WriteLine("1 - El papá de Ryu.");
                Console.WriteLine("2 - Uno de los cuatro guardianes creados por Myria.");
                Console.WriteLine("3 - El elegido del Brood para matar a Myria.");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'El papá de Ryu'.");
                        calificacionFinal += 0;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Uno de los cuatro guardianes creados por Myria'.");
                        calificacionFinal += 1;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'El elegido del Brood para matar a Myria'.");
                        calificacionFinal += 0;
                        break;
                }

                Console.WriteLine(calificacionFinal);

                Console.WriteLine("--------------------------------------------");

                // Cuarta pregunta

                string pregunta4 = preguntas[3];

                Console.WriteLine(pregunta4);
                Console.WriteLine();

                Console.WriteLine("1 - Keizer");
                Console.WriteLine("2 - Kaiser");
                Console.WriteLine("3 - Behemoth");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Keizer'.");
                        calificacionFinal += 0;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Kaiser'.");
                        calificacionFinal += 0;
                        calificacionFinal += 1;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Behemoth'.");
                        calificacionFinal += 0;
                        break;
                }

                Console.WriteLine(calificacionFinal);

                Console.WriteLine("--------------------------------------------");

                // Quinta pregunta

                string pregunta5 = preguntas[4];

                Console.WriteLine(pregunta5);
                Console.WriteLine();

                Console.WriteLine("1 - Con el dinero de McNeil se fueron de viaje a Wyndia.");
                Console.WriteLine("2 - Los guardias de McNeil los llevaron presos a Wyndia.");
                Console.WriteLine("3 - Luego de la batalla se enfrentaron contra Balio y Sunder, perdieron el conocimiento y apareció Ryu sólo.");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Con el dinero de McNeil se fueron de viaje a Wyndia'.");
                        calificacionFinal += 0;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Los guardias de McNeil los llevaron presos a Wyndia'.");
                        calificacionFinal += 0;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elegiste 'Luego de la batalla se enfrentaron contra Balio y Sunder, perdieron el conocimiento y apareció Ryu sólo'.");
                        calificacionFinal += 1;
                        break;
                }

                Console.WriteLine(calificacionFinal);

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("CALIFICACIÓN FINAL:");
                Console.WriteLine();

                switch (calificacionFinal)
                {
                    case 0:
                        Console.WriteLine($"{calificacionFinal}/5 respuestas correctas, minimamente jugá al juego ¡FORRO!.");
                        break;
                    case 1:
                        Console.WriteLine($"Intenta de nuevo, sos la peste - {calificacionFinal}/5 respuestas correctas.");
                        break;
                    case 2:
                        Console.WriteLine($"Nada mal por ser tu primer intento - {calificacionFinal}/5 respuestas correctas.");
                        break;
                    case 3:
                        Console.WriteLine($"¡Bien! algo de atención le prestaste al juego - {calificacionFinal}/5 respuestas correctas.");
                        break;
                    case 4:
                        Console.WriteLine($"¡Casi perfect! Ya casi lo tenés, estuviste muy cerca de la calificación perfecta - {calificacionFinal}/5 respuestas correctas.");
                        break;
                    case 5:
                        Console.WriteLine($"¡Sos un crack! Te ha molao el Breath Of Fire III - {calificacionFinal}/5 respuestas correctas.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("¿Querés intentar de nuevo?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");

                string volverJugar = Console.ReadLine();

                    if (Int32.TryParse(volverJugar, out int volverJugarInt))
                    {
                        switch (volverJugarInt)
                        {
                            case 1:
                                newGame = 0;
                                Console.Clear();
                                break;
                            case 2:
                                newGame = 1;
                                break;
                            default:
                                Console.WriteLine("Tenés que elegir 1 o 2");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debes escribir 1 o 2 en formato numérico.");
                    }
            }

            Console.WriteLine();
            Console.WriteLine("¡Has finalizado la encuesta de Breath Of Fire III, gracias por jugar!");
        }
        }
    }


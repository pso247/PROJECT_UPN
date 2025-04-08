using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GIT_Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vpromedio, vporcentajeasistencia, vcursosdesaprobados, vnivelansiedad, vreportesdisciplina, vhorasestudio, vaccesointernet, vmotivacion,vhorasredes;
            string promedio, porcentajeasistencia, cursosdesaprobados, nivelansiedad, participaextra, reportesdisciplina, horasestudio, accesointernet, motivacion, horasredes;
            
            Console.WriteLine("Ingrese el promedio de notas del estudiante: 0-20");
            promedio = Console.ReadLine();
            vpromedio = int.Parse(promedio);

            Console.WriteLine("Ingrese el porcentaje de asistencia del estudiante: 0-100%");
            porcentajeasistencia = Console.ReadLine();
            vporcentajeasistencia = int.Parse(porcentajeasistencia);

            Console.WriteLine("Ingrese la cantidad de cursos desaprobados del estudiante: ");
            cursosdesaprobados = Console.ReadLine();
            vcursosdesaprobados = int.Parse(cursosdesaprobados);

            Console.WriteLine("Ingrese el nivel de ansiedad del estudiante (1-5):");
            nivelansiedad = Console.ReadLine();
            vnivelansiedad = int.Parse(nivelansiedad);

            Console.WriteLine("Ingrese la cantidad de reportes de disciplina del estudiante:");
            reportesdisciplina = Console.ReadLine();
            vreportesdisciplina = int.Parse(reportesdisciplina);

            Console.WriteLine("Ingrese la cantidad de actividades extracurriculares en las que participa el estudiante:");
            participaextra = Console.ReadLine();

            Console.WriteLine("Ingrese el nivel de motivación del estudiante (1-5):");
            motivacion = Console.ReadLine();
            vmotivacion = int.Parse(motivacion);

            Console.WriteLine("Ingrese la cantidad de horas de estudio del estudiante:");
            horasestudio = Console.ReadLine();
            vhorasestudio = int.Parse(horasestudio);

            Console.WriteLine("Ingrese la cantidad de horas en redes sociales del estudiante:");
            horasredes = Console.ReadLine();
            vhorasredes = int.Parse(horasredes);

            Console.WriteLine("Ingrese la cantidad de horas de acceso a internet del estudiante:");
            accesointernet = Console.ReadLine();
            
            if(vpromedio >= 17 && vpromedio<=20 && vporcentajeasistencia >= 90 && vcursosdesaprobados <= 0 && vnivelansiedad <= 2 && participaextra == "si" && vreportesdisciplina == 0 && vmotivacion >= 4 && vhorasestudio >= 10 && accesointernet =="si" && vhorasredes <=2)
            {
                Console.WriteLine("Candidato a mencion honorífica");
            }
            else if (vpromedio >= 13 && vporcentajeasistencia >= 80 && vcursosdesaprobados <= 1 && vnivelansiedad <= 3 && participaextra == "si" && vreportesdisciplina <= 1 && vmotivacion >= 3 && vhorasestudio >= 7 && accesointernet == "si" && vhorasredes <=4)
            {
                Console.WriteLine("Estudiante equilibrado");
            }
            else if (vpromedio >= 11 && vpromedio < 13 && vporcentajeasistencia >= 60 && vcursosdesaprobados <= 2 && vnivelansiedad <= 4 && participaextra == "si" && vreportesdisciplina <= 2 && vmotivacion >= 2 && vhorasestudio >= 3 && accesointernet == "si" && vhorasredes <=6)
            {
                Console.WriteLine("Estudiante con riesgo medio");
            }
            else
            {
                Console.WriteLine("Estudiante en situacion critica");
            }
            Console.ReadKey();
        }
    }
}

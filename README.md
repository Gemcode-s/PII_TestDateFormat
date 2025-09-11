<!-- markdownlint-disable MD033 MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>
<!-- markdownlint-enable MD033 MD041 -->

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Ejercicio de testing de DateFormat

## Introducción

Uno de los ejercicios que hicimos para que aprendas a hacer en C# las cosas que
sabías hacer en Python fue convertir una función `DateFormat` existente en
Python a la correspondiente en C#. Aquí el punto de partida es la solución a ese
ejercicio.

Agregamos dos desafíos más:

* Crear la estructura de carpetas y proyectos.

* Comenzar escribiendo los casos de prueba.

El la mayoría de los ejercicios hasta ahora te dábamos un repositorio para
clonar o para usar como plantilla. Ahora también te damos un repositorio y el
código de partida, pero tú deberás crear la estructa de carpetas y proyectos.

Los comandos para eso ya te los dimos, pero los repasaremos en este ejercicio.

## Pasos

1. Crea tu propio repositorio a partir de esta plantilla y clona ese repositorio
   en tu equipo.

2. Usando la terminal integrada en Rider, completa los pasos 2 a 13 indicados
   [aquí](https://github.com/ucudal/PII_Comandos/blob/master/Crear_Proyecto_C%23.md).

   Debería quedar una estructra como la siguiente:

   ```none
   docs/
   src/
      Program/
         Program.csproj
      Library/
         Library.csproj
   test/
      Library.Tests/
         Library.Tests.csproj
   ```

3. En la carpeta `./src/Program`, reemplaza el contenido del archivo
   `Program.cs` con este contenido:

   ```csharp
   using System;

   namespace Ucu.Poo.TestDateFormat
   {
      /// <summary>
      /// El programa principal.
      /// </summary>
      public static class Program
      {
         /// <summary>
         /// Punto de entrada al programa principal.
         /// </summary>
         public static void Main()
         {
                  string testDate = "10/11/1997";
                  DateFormatter df = new DateFormatter();
                  Console.WriteLine($"{testDate} se convierte a {df.ChangeFormat(testDate)}");
         }
      }
   }
   ```

4. En la carpeta `./src/Library`, renombra el archivo `Class1.cs` por
   `DateFormatter.cs`, y reemplaza el contenido de ese archivo con este
   contenido:

   ```csharp
   namespace Ucu.Poo.TestDateFormat
   {
      /// <summary>
      /// Esta clase implementa la funcionalidad de cambiar el formato de una
      /// fecha.
      /// </summary>
      public class DateFormatter
      {

         /// <summary>
         /// Cambia el formato de la fecha que se recibe como argumento. La fecha
         /// que se recibe como argumento se asume en formato "dd/mm/yyyy" y se
         /// retorna en formato "yyyy-mm-dd". No se controla que la fecha
         /// recibida tenga el formato asumido.
         /// </summary>
         /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
         /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
         public string ChangeFormat(string date)
         {
               return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
         }
      }
   }
   ```

5. En la carpeta `./test/Library.Tests`, renombra el archivo `UnitTests1.cs` a
    `DateFormatterTests` y la clase que contiene de `Tests` a
   `DateFormatterTests`. La convención es que haya una clase de prueba para cada
   clase a probar con el mismo nombre, y el sufijo `Tests`. Como la clase a
   probar es `DateFormatter`, la clase de prueba es `DateFormatterTests`, y el
   archivo `DateFormatterTests.cs` porque, también por convención, el archivo
   tiene el nombre de la clase que contiene.

6. Haz uno caso de prueba para la función `string ChangeFormat(string)`. Elije
   alguno los siguientes escenarios:

   * Una fecha en formato correcto

   * Una fecha que no tenga el formato correcto

   * Una fecha en blanco

   Recuerda hacer un caso de prueba, es decir, un método con el atributo
   `[Test]`, para cada escenario a probar. Te sugerimos que para los nombres de
   los casos de prueba uses la convención `Method_Scenario_ExpectedResult`. Por
   ejemplo, para algunos de los escenarios anteriores, podrías usar:

   * `ChangeFormat_ValidInputDate_ReturnsConvertedDate`.

   * `ChangeFormat_InvalidInputDate_ReturnsEmpty`

   * `ChangeFormat_EmptyInput_ReturnsEmpty`

   No olvides seguir la estructura `Arrange`, `Act`, `Assert` para programar los
   casos de prueba.

7. Corrige el código provisto, para que pasen el nuevo caso de prueba.

8. Repite los pasos 6 y 7 para nuevos escenarios.


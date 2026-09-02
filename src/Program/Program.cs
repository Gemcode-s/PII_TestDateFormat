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
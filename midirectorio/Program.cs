using System;
using System.IO;

namespace midirectorio
{
    public class Program
    {
        public static void Main()
        {
            // hace una lista de los archivos del directorio c
            String miDirectorio = @"c:\";   // crea la variable mi directorio
            String[] listaFicheros;   // crea la variable listaFicheros 
            listaFicheros = Directory.GetFiles(miDirectorio);
            foreach(String fichero in listaFicheros)   // hace que los escriba de uno en uno por renglon
            Console.WriteLine(fichero);
            Console.ReadKey();
        }
    }
}

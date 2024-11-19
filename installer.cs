// this code also does literally nothing, nice shitty ai generated code that does nothing

using System;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace InstaladorFicticio
{
    class Program
    {
        static void Main(string[] args)
        {
            string downloadUrl = "https://www.google.com"; 
            string fileName = "Saolara.exe"; 
            string filePath = Path.Combine(Path.GetTempPath(), fileName); 

            Console.WriteLine("Descargando archivo desde: " + downloadUrl);
            
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(downloadUrl, filePath);
                }

                Console.WriteLine("Archivo descargado en: " + filePath);

                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true 
                });

                Console.WriteLine("Archivo ejecutado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

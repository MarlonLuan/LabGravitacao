using System;
using System.IO;
using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public static class Auxiliar
    {
        public static string LerArquivo(string nomeArquivo)
        {
            string result = "";

            
            string caminho = Constantes.caminhoTexto + nomeArquivo + ".gravit";

            string text = System.IO.File.ReadAllText(caminho);
            /*
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(caminho))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    result = line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }*/

            result = text;
            return result;
        }

        public static void DesativarAtalhos()
        {
            try
            {

                //GameObject V_Vazio_Scripts_Back = GameObject.Find("V_Vazio_Scripts_Back");

                //V_Vazio_Scripts_Back.SetActive(false);
                Constantes.PermitidoAtalho = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AtivarAtalhos()
        {
            try
            {

                //GameObject V_Vazio_Scripts_Back = GameObject.Find("V_Vazio_Scripts_Back");

                //V_Vazio_Scripts_Back.SetActive(true);

                Constantes.PermitidoAtalho = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

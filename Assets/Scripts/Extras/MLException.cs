using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public static class MLException
    {
        public static void Gerar(string param)
        {
            throw new System.Exception(param);
        }

        public static void Gerar(System.Exception param)
        {
            throw param;
        }
    }
}
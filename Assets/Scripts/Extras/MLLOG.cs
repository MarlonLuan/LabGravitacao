using System;
using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public static class MLLOG
    {
        public enum LOGTipoEnum
        {
            Log,
            Error,
            Exception,
            Warning,
            NotDefinition
        }

        public static void Save(string param)
        {
            //Debug.Log(param);
        }

        public static void Print(string param, LOGTipoEnum tipo = LOGTipoEnum.NotDefinition)
        {
            switch (tipo)
            {
                case LOGTipoEnum.Log:
                    Debug.Log(param);
                    break;
                case LOGTipoEnum.Error:
                    Debug.LogError(param);
                    break;
                case LOGTipoEnum.Exception:
                    Debug.LogException(new Exception(param));
                    break;
                case LOGTipoEnum.Warning:
                    Debug.LogWarning(param);
                    break;
                default:
                    Debug.Log(param);
                    break;
            }
        }
    }
}
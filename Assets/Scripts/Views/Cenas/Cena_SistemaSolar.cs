using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_SistemaSolar : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.SistemaSolar();
            ModeloContextoCena.FundoMenu = Cena1Coluna.fundoMenu;
        }
    }
}
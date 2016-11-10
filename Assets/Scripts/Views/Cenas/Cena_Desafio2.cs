using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Desafio2 : Cena_Desafios_HERDAR
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.Desafio2();
            ModeloContextoCena.FundoMenu = Cena1Coluna.fundoMenu;
        }
    }
}
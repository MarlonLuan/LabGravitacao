using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Login : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.Login();
            ModeloContextoCena.FundoMenu = Cena1Coluna.fundoMenu;
        }
    }
}
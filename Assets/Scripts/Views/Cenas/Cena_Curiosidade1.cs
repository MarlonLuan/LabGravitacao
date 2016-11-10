﻿using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Curiosidade1 : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.Curiosidade1();
            ModeloContextoCena.FundoMenu = Cena1Coluna.fundoMenu;
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class FormBotaoEntrar : ItemFormMModel
    {
        public FormBotaoEntrar()
        {
            LabelTextField = new string[] { "Entrar" };
            TamanhoTextField = 1;
            Dica = "Entrar";
            FundoItem = new Rect[] {
                Menu1Coluna.fundoBotao3
            };
        }
    }
}
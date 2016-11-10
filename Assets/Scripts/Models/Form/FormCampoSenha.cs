using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class FormCampoSenha : ItemFormMModel
    {
        public FormCampoSenha()
        {
            //LabelTextField = new string[] { "Senha", "" };
            LabelTextField = new string[] { "Senha", "********" };
            TamanhoTextField = 1;
            isObrigatorio = true;
            TextObrigatorio = "Campo Obrigatório";
            Dica = "Informe a senha";
            FundoItem = new Rect[] {
                Menu1Coluna.fundoBotao3,
                Menu1Coluna.fundoBotao4
            };
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class FormCampoLogin : ItemFormMModel
    {
        public FormCampoLogin()
        {
            //LabelTextField = new String[] { "Usuário", "" };
            LabelTextField = new string[] { "Usuário", Constantes.usuarioLogado.Nome };
            TamanhoTextField = 1;
            isObrigatorio = true;
            TextObrigatorio = "Campo Obrigatório";
            Dica = "Informe o usuário";
            FundoItem = new Rect[] {
                Menu1Coluna.fundoBotao1,
                Menu1Coluna.fundoBotao2
            };
        }
    }
}
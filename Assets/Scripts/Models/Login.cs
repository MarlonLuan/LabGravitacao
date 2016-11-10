using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Login : MModel, MLFramework_.IBotao
    {
        public Login(string _Label = Constantes.Label_MenuLogin)
        {
            ModelCena = CenaEnum.Login;
            ModelTipo = ModelTipoEnum.Formulario;

            Id = Constantes.Id_MenuLogin;
            Label = _Label;
            Help = Constantes.Help_MenuLogin;
            
            MenuListaMenusInternos = new MModel[] {
                null,
                null,
                null,
                null,
                null,
                new MenuPrincipal(Constantes.Label_Entrar)
                //new TelaInicial()
            };
            FormularioListaItensFormulario = new ItemFormMModel[] {
                new FormCampoLogin(),
                new FormCampoSenha()
            };
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao5;
            //FundoMenu = new Rect();
        }
    }
}
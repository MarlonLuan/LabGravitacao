using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class MenuPrincipal : MModel, MLFramework_.IBotao
    {
        public MenuPrincipal(string _Label = Constantes.Label_MenuPrincipal)
        {
            ModelCena = CenaEnum.MenuPrincipal;
            ModelTipo = ModelTipoEnum.Menu;
            MenuEnum = MenuEnum.MenuPrincipal;

            Id = Constantes.Id_MenuPrincipal;
            Label = _Label;
            Help = Constantes.Help_MenuPrincipal;

            MenuListaMenusInternos = new MModel[] {
                new MenuConteudo(),
                new MenuDesafios(),
                new MenuCuriosidades(),
                new Configuracoes(),
                new MenuAjuda(),
                null
                //new Voltar()
                //new Login(Constantes.Label_Sair)
            };
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao6;
            //FundoMenu = new Rect();
        }

        public override void AoClicar()
        {
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuPrincipal;
            base.AoClicar();
        }
    }
}
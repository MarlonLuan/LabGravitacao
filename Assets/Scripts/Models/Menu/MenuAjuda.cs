using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class MenuAjuda : MModel, MLFramework_.IBotao
    {
        public MenuAjuda()
        {
            ModelCena = CenaEnum.MenuAjuda;
            ModelTipo = ModelTipoEnum.Menu;
            MenuEnum = MenuEnum.MenuAjuda;

            Id = Constantes.Id_MenuAjuda;
            Label = Constantes.Label_MenuAjuda;
            Help = Constantes.Help_MenuAjuda;

            MenuListaMenusInternos = new MModel[] {
                new Sobre(),
                new Creditos(),
                null,
                null,
                null,
                null,
                //new Voltar()
                //new MenuPrincipal(Constantes.Id_Voltar)
                //new MenuGeral(Constantes.Id_Voltar)
            };
            FormularioListaItensFormulario = null;
            SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao5;
            FundoMenu = new Rect();
        }

        public override void AoClicar()
        {
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuAjuda;
            base.AoClicar();
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class MenuCuriosidades : MModel, MLFramework_.IBotao
    {
        public MenuCuriosidades()
        {
            ModelCena = CenaEnum.MenuCuriosidades;
            ModelTipo = ModelTipoEnum.Menu;
            MenuEnum = MenuEnum.MenuCuriosidades;

            Id = Constantes.Id_MenuCuriosidades;
            Label = Constantes.Label_MenuCuriosidades;
            Help = Constantes.Help_MenuCuriosidades;

            MenuListaMenusInternos = new MModel[] {
                new Curiosidade1(),
                new Curiosidade2(),
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
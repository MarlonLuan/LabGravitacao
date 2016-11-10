using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class MenuDesafios : MModel, MLFramework_.IBotao
    {
        public MenuDesafios()
        {
            ModelCena = CenaEnum.MenuDesafios;
            ModelTipo = ModelTipoEnum.Menu;
            MenuEnum = MenuEnum.MenuDesafios;

            Id = Constantes.Id_MenuDesafios;
            Label = Constantes.Label_MenuDesafios;
            Help = Constantes.Help_MenuDesafios;

            MenuListaMenusInternos = new MModel[] {
                new Desafio1(),
                new Desafio2(),
                new Desafio3(),
                new Desafio4(),
                new Desafio5(),
                null,
                null
            };
            FormularioListaItensFormulario = null;
            SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao2;
            //FundoMenu = new Rect();
        }

        public override void AoClicar()
        {
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuDesafios;
            base.AoClicar();
            //MCena.CarregarCena(this);
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class TelaInicial : MModel, MLFramework_.IBotao
    {
        public TelaInicial()
        {
            ModelCena = CenaEnum.TelaInicial;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_TelaInicial;
            Label = Constantes.Label_TelaInicial;
            Help = Constantes.Help_TelaInicial;

            MenuListaMenusInternos = new MModel[] {
                null,
                null,
                null,
                null,
                null,
                new Login()
            };
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class TerceiraLeiKepler : MModel, MLFramework_.IBotao
    {
        public TerceiraLeiKepler()
        {
            ModelCena = CenaEnum.TerceiraLeiKepler;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_TerceiraLeiKepler;
            Label = Constantes.Label_TerceiraLeiKepler;
            Help = Constantes.Help_TerceiraLeiKepler;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao4;
            //FundoMenu = new Rect();
        }
    }
}
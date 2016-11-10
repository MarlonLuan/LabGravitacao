using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class SegundaLeiKepler : MModel, MLFramework_.IBotao
    {
        public SegundaLeiKepler()
        {
            ModelCena = CenaEnum.SegundaLeiKepler;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_SegundaLeiKepler;
            Label = Constantes.Label_SegundaLeiKepler;
            Help = Constantes.Help_SegundaLeiKepler;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao3;
            //FundoMenu = new Rect();
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class LeiGravitacaoUniversal : MModel, MLFramework_.IBotao
    {
        public LeiGravitacaoUniversal()
        {
            ModelCena = CenaEnum.LeiGravitacaoUniversal;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_LeiGravitacaoUniversal;
            Label = Constantes.Label_LeiGravitacaoUniversal;
            Help = Constantes.Help_LeiGravitacaoUniversal;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao5;
            //FundoMenu = new Rect();
        }
    }
}
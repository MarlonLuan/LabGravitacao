using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class PrimeiraLeiKepler : MModel, MLFramework_.IBotao
    {
        public PrimeiraLeiKepler()
        {
            ModelCena = CenaEnum.PrimeiraLeiKepler;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_PrimeriaLeiKepler;
            Label = Constantes.Label_PrimeiraLeiKepler;
            Help = Constantes.Help_PrimeiraLeiKepler;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao2;
            //FundoMenu = new Rect();
        }
    }
}
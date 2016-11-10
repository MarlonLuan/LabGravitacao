using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Conversor : MModel, MLFramework_.IBotao
    {
        public Conversor()
        {
            ModelCena = CenaEnum.Conversor;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Conversor;
            Label = Constantes.Label_Conversor;
            Help = Constantes.Help_Conversor;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao6;
            //FundoMenu = new Rect();
        }
    }
}
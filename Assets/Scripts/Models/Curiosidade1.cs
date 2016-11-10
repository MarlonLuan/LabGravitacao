using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Curiosidade1 : MModel, MLFramework_.IBotao
    {
        public Curiosidade1()
        {
            ModelCena = CenaEnum.Curiosidade1;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Curiosidade1;
            Label = Constantes.Label_Curiosidade1;
            Help = Constantes.Help_Curiosidade1;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
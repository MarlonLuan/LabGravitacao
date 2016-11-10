using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Curiosidade2 : MModel, MLFramework_.IBotao
    {
        public Curiosidade2()
        {
            ModelCena = CenaEnum.Curiosidade2;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Curiosidade2;
            Label = Constantes.Label_Curiosidade2;
            Help = Constantes.Help_Curiosidade2;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
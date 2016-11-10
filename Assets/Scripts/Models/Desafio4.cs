using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Desafio4 : MModel, MLFramework_.IBotao
    {
        public Desafio4()
        {
            ModelCena = CenaEnum.Desafio4;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Desafio4;
            Label = Constantes.Label_Desafio4;
            Help = Constantes.Help_Desafio4;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
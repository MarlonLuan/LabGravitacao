using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Desafio5 : MModel, MLFramework_.IBotao
    {
        public Desafio5()
        {
            ModelCena = CenaEnum.Desafio5;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Desafio5;
            Label = Constantes.Label_Desafio5;
            Help = Constantes.Help_Desafio5;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
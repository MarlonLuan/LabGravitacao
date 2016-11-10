using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Desafio1 : MModel, MLFramework_.IBotao
    {
        public Desafio1()
        {
            ModelCena = CenaEnum.Desafio1;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Desafio1;
            Label = Constantes.Label_Desafio1;
            Help = Constantes.Help_Desafio1;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
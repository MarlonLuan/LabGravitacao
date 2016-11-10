using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Desafio3 : MModel, MLFramework_.IBotao
    {
        public Desafio3()
        {
            ModelCena = CenaEnum.Desafio3;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Desafio3;
            Label = Constantes.Label_Desafio3;
            Help = Constantes.Help_Desafio3;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
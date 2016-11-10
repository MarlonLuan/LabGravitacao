using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Desafio2 : MModel, MLFramework_.IBotao
    {
        public Desafio2()
        {
            ModelCena = CenaEnum.Desafio2;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Desafio2;
            Label = Constantes.Label_Desafio2;
            Help = Constantes.Help_Desafio2;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
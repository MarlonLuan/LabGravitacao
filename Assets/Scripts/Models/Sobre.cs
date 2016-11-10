using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Sobre : MModel, MLFramework_.IBotao
    {
        public Sobre()
        {
            ModelCena = CenaEnum.Sobre;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Sobre;
            Label = Constantes.Label_Sobre;
            Help = Constantes.Help_Sobre;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
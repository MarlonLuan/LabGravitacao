using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class SistemaSolar : MModel, MLFramework_.IBotao
    {
        public SistemaSolar()
        {
            ModelCena = CenaEnum.SistemaSolar;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_SistemaSolar;
            Label = Constantes.Label_SistemaSolar;
            Help = Constantes.Help_SistemaSolar;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }
    }
}
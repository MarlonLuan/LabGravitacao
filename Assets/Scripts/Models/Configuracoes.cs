using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Configuracoes : MModel, MLFramework_.IBotao
    {
        public Configuracoes()
        {
            ModelCena = CenaEnum.Configuracoes;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Configuracoes;
            Label = Constantes.Label_Configuracoes;
            Help = Constantes.Help_Configuracoes;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao4;
            //FundoMenu = new Rect();
        }
    }
}
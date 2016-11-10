using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Creditos : MModel, MLFramework_.IBotao
    {
        public Creditos()
        {
            ModelCena = CenaEnum.Creditos;
            ModelTipo = ModelTipoEnum.Simulador;

            Id = Constantes.Id_Creditos;
            Label = Constantes.Label_Creditos;
            Help = Constantes.Help_Creditos;

            MenuListaMenusInternos = new MModel[] {
                null,
                null,
                null,
                null,
                null,
                null
                //new MenuPrincipal(Constantes.Label_Voltar)
            };
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao2;
            //FundoMenu = new Rect();
        }
    }
}
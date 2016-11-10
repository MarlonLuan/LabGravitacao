using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class Sair : MModel, MLFramework_.IBotao
    {
        public Sair()
        {
            //ModelCena = CenaEnum.0;
            ModelTipo = ModelTipoEnum.Botao;

            Id = Constantes.Id_Sair;
            Label = Constantes.Label_Sair;
            Help = Constantes.Help_Sair;

            //MenuListaMenusInternos = null;
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao7;
            //FundoMenu = new Rect();
        }

        public override void AoClicar()
        {
            MLLOG.Save(Constantes.Log_ClickBotao + Label);
            //if (MCena == null)
            if (true)
            {
                MLLOG.Save(Constantes.Log_Sair);
                Application.Quit();
            }
        }
    }
}
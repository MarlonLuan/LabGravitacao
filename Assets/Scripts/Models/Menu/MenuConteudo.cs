using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class MenuConteudo : MModel, MLFramework_.IBotao
    {
        public MenuConteudo()
        {
            ModelCena = CenaEnum.MenuConteudo;
            ModelTipo = ModelTipoEnum.Menu;
            MenuEnum = MenuEnum.MenuConteudo;

            Id = Constantes.Id_MenuConteudo;
            Label = Constantes.Label_MenuConteudo;
            Help = Constantes.Help_MenuConteudo;

            MenuListaMenusInternos = new MModel[] {
                new SistemaSolar(),
                new PrimeiraLeiKepler(),
                new SegundaLeiKepler(),
                new TerceiraLeiKepler(),
                new LeiGravitacaoUniversal(),
                new Conversor()
                //new Voltar()
                //new MenuPrincipal(Constantes.Id_Voltar)
                //new MenuGeral(Constantes.Id_Voltar)
            };
            //FormularioListaItensFormulario = null;
            //SimuladorListaItensInternos = null;

            //BotaoFundo = Menu1Coluna.fundoBotao1;
            //FundoMenu = new Rect();
        }

        public override void AoClicar()
        {
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuConteudo;
            base.AoClicar();
        }
    }
}
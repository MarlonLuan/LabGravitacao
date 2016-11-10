using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MLFramework_ = MarlonLuan.MLFramework.Unity.Scripts.Interfaces;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public abstract class MModel
    {
        public MModel()
        {
            MLLOG.Print("MModel: " + ModelCena);
        }

        /*
        TelaInicial,
        Login,
        MenuPrincipal,
        MenuExercicios,
        Funcao1Grau,
        Bhaskara,
        Conversor,
        MenuDesafios,
        Hanoi,
        Configuracoes,
        Creditos,
        MenuInferior,
        Ajuda
        */
        public CenaEnum ModelCena { get; set; }

        /*
        Botao,
        Formulario,
        Menu,
        Simulador
        */
        public ModelTipoEnum ModelTipo { get; set; }

        public string Id { get; set; }
        public string Label { get; set; }
        public string Help { get; set; }

        #region ModelTipoEnum.Menu
        public MModel[] MenuListaMenusInternos { get; set; }
        public MenuEnum MenuEnum { get; set; }
        #endregion

        #region ModelTipoEnum.Formulario
        //public MModel[] ListaItensInternos { get; set; }
        public ItemFormMModel[] FormularioListaItensFormulario { get; set; }
        #endregion

        #region ModelTipoEnum.Simulador
        public MModel[] SimuladorListaItensInternos { get; set; }
        #endregion

        #region ModelTipoEnum.Botao
        //public Rect BotaoFundo { get; set; }
        #endregion

        public Rect FundoMenu { get; set; }

        public virtual void AoClicar()
        {
            MCena.CarregarCena(this);
        }

    }
}

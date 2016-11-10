using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public abstract class MCena : MonoBehaviour
    {
        //Toda Cena possui um MModel associado
        //Que irá definir qual o comportamento da Cena
        public MLFramework_Models.MModel ModeloContextoCena { get; set; }
        
        
        //protected void Start()
        //{
           // MCenaHistorico.AdicionarCena(this.ModeloContextoCena);

        //}
        
        //Ao construir a tela
        protected void OnGUI()
        {
            GUI.Box(ModeloContextoCena.FundoMenu, SceneManager.GetActiveScene().name);

            //Verifica o tipo da cena, para relizar o preenchimento
            switch (ModeloContextoCena.ModelTipo)
            {
                case ModelTipoEnum.Botao:
                    break;
                case ModelTipoEnum.Formulario:
                    GerarFormulario(ModeloContextoCena.FormularioListaItensFormulario);
                    GerarMenus(ModeloContextoCena.MenuListaMenusInternos);
                    break;
                case ModelTipoEnum.Menu:
                    GerarMenus(ModeloContextoCena.MenuListaMenusInternos);
                    break;
                case ModelTipoEnum.Simulador:
                    GerarFormulario(ModeloContextoCena.FormularioListaItensFormulario);
                    GerarMenus(ModeloContextoCena.MenuListaMenusInternos);
                    break;
                default:
                    break;
            }
        }

        protected void GerarFormulario(MLFramework_Models.ItemFormMModel[] formulario)
        {
            //Preenche a tela com campos do formulário
            if (formulario != null && formulario.Length >= 0)
                foreach (MLFramework_Models.ItemFormMModel Item in formulario)
                {
                    if (Item != null)
                    {
                        int i = 0;

                        GUI.Label(Item.FundoItem[i], Item.LabelTextField[i]);
                        i++;

                        GUI.TextField(Item.FundoItem[i], Item.LabelTextField[i]);
                        i++;
                    }
                }
        }

        protected void GerarMenus(MLFramework_Models.MModel[] listaMenu)
        {
            //Preenche a tela com a lista de botões para outras telas
            if (listaMenu != null && listaMenu.Length >= 0)
                for (int i = 0; i < listaMenu.Length; i++)
                {
                    if (listaMenu[i] != null)
                    {
                        if (GUI.Button(Menu1Coluna.fundoBotaoLista[i], listaMenu[i].Label))
                        {
                            listaMenu[i].AoClicar();
                        }
                    }
                }
        }


        public static void CarregarCena(MLFramework_Models.MModel mmodel)
        {
            //MLLOG.Print("Quantidade: " + MCenaHistorico.Quantidade().ToString(), MLLOG.LOGTipoEnum.Error);
            //MLLOG.Print("Model: " + mmodel.ToString(), MLLOG.LOGTipoEnum.Error);
            //------------------MCenaHistorico.AdicionarCena(mmodel);
            //MLLOG.Print("Quantidade: " + MCenaHistorico.Quantidade().ToString(), MLLOG.LOGTipoEnum.Error);
            //MLLOG.Print("GetModelCenaAnterior: " + MCenaHistorico.GetModelCenaAnterior().ToString(), MLLOG.LOGTipoEnum.Error);
            /*try
            {
                MLLOG.Print("GetVarUltimaCena: " + MCenaHistorico.GetVarUltimaCena().ToString(), MLLOG.LOGTipoEnum.Error);
            }
            catch
            {
                MLLOG.Print("-----------------: ", MLLOG.LOGTipoEnum.Error);
            }

            foreach (MLFramework_Models.MModel item in MCenaHistorico.listaModelCenas)
            {
                MLLOG.Print("MCENA___" + item.Id, MLLOG.LOGTipoEnum.Error);
            }*//*
            try
            {

            if (isCenaMenu(mmodel.Id) && false)
            {
                //SceneManager.LoadScene(new MLFramework_Models.MenuGeral().Id, LoadSceneMode.Single);
            }
            else
            {
                    //SceneManager.LoadScene(mmodel.Id, LoadSceneMode.Single);
                }
            }
            catch (Exception)
            {

                throw;
            }*/

            SceneManager.LoadScene(mmodel.Id, LoadSceneMode.Single);
        }

        private static bool isCenaMenu(string id)
        {
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuPrincipal;

            bool resultado = false;
            if (id == new MLFramework_Models.MenuPrincipal().Id)
            {
                //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuPrincipal;
                resultado = true;
            }
            if (id == new MLFramework_Models.MenuConteudo().Id)
            {
                //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuConteudo;
                resultado = true;
            }
            if (id == new MLFramework_Models.MenuDesafios().Id)
            {
                //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuDesafios;
                resultado = true;
            }
            if (id == new MLFramework_Models.MenuAjuda().Id)
            {
                //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuAjuda;
                resultado = true;
            }

            return resultado;
        }
    }
}

using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class MCena : MonoBehaviour
    {
        public MLFramework_Models.MModel ModeloContextoCena { get; set; }
        
        protected void OnGUI()
        {
        //    GUI.Box(ModeloContextoCena.FundoMenu, ModeloContextoCena.Id);
            GUI.Box(ModeloContextoCena.FundoMenu, "");


            GerarFormulario(ModeloContextoCena.FormularioListaItensFormulario);
            GerarMenus(ModeloContextoCena.MenuListaMenusInternos);

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

            SceneManager.LoadScene(mmodel.Id, LoadSceneMode.Single);
        }
    }
}
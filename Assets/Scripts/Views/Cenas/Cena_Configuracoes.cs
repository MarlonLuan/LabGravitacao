using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Configuracoes : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.Configuracoes();
            ModeloContextoCena.FundoMenu = Cena2Colunas.fundoMenu;
        }

        private Rect viewArea;
        private float posicaoX = 1;
        private float posicaoY = 1;
        private float tamanhoX = 1;
        private float tamanhoY = 1;
        public float velocidade = 29.0f;
        public string text = "";

        // Use this for initialization
        void Start()
        {
            //base.Start();
            viewArea = MenuVertical.fundoMenu;

            var var_InputField_Nome = GameObject.Find("InputField_Nome");
            if (var_InputField_Nome != null)
            {
                InputField InputField_Nome = var_InputField_Nome.GetComponent<InputField>();
                var se = new InputField.SubmitEvent();
                se.AddListener(SubmitNameInputField_Nome);
                InputField_Nome.onEndEdit = se;
                InputField_Nome.transform.parent.position = new Vector3(0, 0, 0);
                InputField_Nome.transform.position = new Vector3(0, 0, 0) + InputField_Nome.transform.parent.position;
                InputField_Nome.text = Constantes.usuarioLogado.Nome;

            }

            var var_InputField_Excentricidade = GameObject.Find("InputField_Excentricidade");
            if (var_InputField_Excentricidade != null)
            {
                InputField InputField_Excentricidade = var_InputField_Excentricidade.GetComponent<InputField>();
                var se = new InputField.SubmitEvent();
                se.AddListener(SubmitName_InputField_Excentricidade);
                InputField_Excentricidade.onEndEdit = se;
                InputField_Excentricidade.transform.parent.position = new Vector3(0, 0, 0);
                InputField_Excentricidade.transform.position = new Vector3(0, 0, 0) + InputField_Excentricidade.transform.parent.position;
                InputField_Excentricidade.text = Constantes.eccentricity.ToString();
            }
        }

        void onUpdates()
        {
            int cont = 0;
            var gameOjects = GameObject.FindObjectsOfType<InputField>();
            foreach (var gameOject in gameOjects)
            {
                if (gameOject.isFocused)
                {
                    Auxiliar.DesativarAtalhos();
                    cont++;
                }                
            }

            if (cont == 0)
            {

                Auxiliar.AtivarAtalhos();
            }

        }

        new void OnGUI()
        {

            onUpdates();

            GUI.Box(Cena2Colunas.fundoMenu, SceneManager.GetActiveScene().name);

            int qtDivisoes = 5;

            //#region area1
            text = "\r\n" + "As informações são salvas automaticamente";
            Rect viewArea1 = viewArea;
            viewArea1.height = viewArea.height * 2 / qtDivisoes;
            GUI.BeginGroup(viewArea1);
            var posicao1 = new Rect(posicaoX, posicaoY, viewArea1.width, viewArea1.height);
            GUI.Label(posicao1, text);
            GUI.EndGroup();

            //#region area2
            text = "";
            Rect viewArea2 = viewArea;
            viewArea2.height = viewArea.height * 1 / qtDivisoes;
            viewArea2.x = viewArea.x;
            viewArea2.y = viewArea1.y + viewArea1.height;
            GUI.BeginGroup(viewArea2);
            var posicao2 = new Rect(posicaoX, posicaoY, viewArea2.width, viewArea2.height);
            GUI.Label(posicao2, text);

            var var_InputField_Nome = GameObject.Find("InputField_Nome");
            if (var_InputField_Nome != null)
            {
                InputField InputField_Nome = var_InputField_Nome.GetComponent<InputField>();
                InputField_Nome.transform.position = new Vector3(0, 0, 0) + InputField_Nome.transform.parent.position;
                var rectTransform = InputField_Nome.GetComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(viewArea.width / 2, rectTransform.sizeDelta.y);
                InputField_Nome.transform.position = new Vector3(InputField_Nome.transform.position.x + rectTransform.sizeDelta.x / 2, InputField_Nome.transform.position.y, InputField_Nome.transform.position.z);
                
                var var_Text_Nome = GameObject.Find("Text_Nome");
                Text Text_Nome = var_Text_Nome.GetComponent<Text>();
                Text_Nome.transform.position = new Vector3(0, 0, 0) + var_Text_Nome.transform.parent.position;
                var rectTransform2 = var_Text_Nome.GetComponent<RectTransform>();
                rectTransform2.sizeDelta = new Vector2(viewArea.width / 2, rectTransform2.sizeDelta.y);
                Text_Nome.transform.position = new Vector3(Text_Nome.transform.position.x - rectTransform2.sizeDelta.x / 2, Text_Nome.transform.position.y, Text_Nome.transform.position.z);
            }
            GUI.EndGroup();


            //#region area3
            text = "";
            Rect viewArea3 = viewArea;
            viewArea3.height = viewArea.height * 1 / qtDivisoes;
            viewArea3.x = viewArea.x;
            viewArea3.y = viewArea2.y + viewArea2.height;
            GUI.BeginGroup(viewArea3);
            var posicao3 = new Rect(posicaoX, posicaoY, viewArea3.width, viewArea3.height);
            GUI.Label(posicao3, text);

            var va_InputField_Excentricidade = GameObject.Find("InputField_Excentricidade");
            if (va_InputField_Excentricidade != null)
            {
                InputField InputField_Excentricidade = va_InputField_Excentricidade.GetComponent<InputField>();
                InputField_Excentricidade.transform.position = new Vector3(0, 0, 0) + InputField_Excentricidade.transform.parent.position;
                var rectTransform = InputField_Excentricidade.GetComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(viewArea.width / 2, rectTransform.sizeDelta.y);
                InputField_Excentricidade.transform.position = new Vector3(InputField_Excentricidade.transform.position.x + rectTransform.sizeDelta.x / 2, InputField_Excentricidade.transform.position.y + 40, InputField_Excentricidade.transform.position.z);

                var var_Text_Excentricidade = GameObject.Find("Text_Excentricidade");
                Text Text_Excentricidade = var_Text_Excentricidade.GetComponent<Text>();
                Text_Excentricidade.transform.position = new Vector3(0, 0, 0) + var_Text_Excentricidade.transform.parent.position;
                var rectTransform2 = var_Text_Excentricidade.GetComponent<RectTransform>();
                rectTransform2.sizeDelta = new Vector2(viewArea.width / 2, rectTransform2.sizeDelta.y);
                Text_Excentricidade.transform.position = new Vector3(Text_Excentricidade.transform.position.x - rectTransform2.sizeDelta.x / 2, Text_Excentricidade.transform.position.y + 40, Text_Excentricidade.transform.position.z);
            }
            GUI.EndGroup();
        }

        private void SubmitNameInputField_Nome(string arg0)
        {
            try
            {
                string nome = arg0;

                Constantes.usuarioLogado.Nome = nome;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                Auxiliar.AtivarAtalhos();
            }
        }

        private void SubmitName_InputField_Excentricidade(string arg0)
        {
            try
            {
                string nome = arg0;// + 'f';

                Constantes.eccentricity = float.Parse(nome.ToString()) ;
            }
            catch (System.Exception e)
            {
                throw;
            }
            finally
            {
                Auxiliar.AtivarAtalhos();
            }
        }
    }
}
using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Conversor : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new MLFramework_Models.Conversor();
            ModeloContextoCena.FundoMenu = Cena1Coluna.fundoMenu;
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

            var var_InputField_T = GameObject.Find("InputField_T");
            if (var_InputField_T != null)
            {
                InputField InputField_T = var_InputField_T.GetComponent<InputField>();
                var se = new InputField.SubmitEvent();
                se.AddListener(SubmitNameInputField_T);
                InputField_T.onEndEdit = se;
                InputField_T.transform.parent.position = new Vector3(0, 0, 0);
                InputField_T.transform.position = new Vector3(0, 0, 0) + InputField_T.transform.parent.position;
            }

            var var_InputField_R = GameObject.Find("InputField_R");
            if (var_InputField_R != null)
            {
                InputField InputField_R = var_InputField_R.GetComponent<InputField>();
                var se = new InputField.SubmitEvent();
                se.AddListener(SubmitNameInputField_R);
                InputField_R.onEndEdit = se;
                InputField_R.transform.parent.position = new Vector3(0, 0, 0);
                InputField_R.transform.position = new Vector3(0, 0, 0) + InputField_R.transform.parent.position;
            }
        }

        new void OnGUI()
        {
            GUI.Box(Cena1Coluna.fundoMenu, SceneManager.GetActiveScene().name);

            int qtDivisoes = 5;

            //#region area1
            text = "Conversor de unidades";
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
            //GUI.Label(posicao2, text);

            var var_InputField_T = GameObject.Find("InputField_T");
            if (var_InputField_T != null)
            {
                InputField InputField_T = var_InputField_T.GetComponent<InputField>();
                InputField_T.transform.position = new Vector3(0, 0, 0) + InputField_T.transform.parent.position;
                var rectTransform = InputField_T.GetComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(viewArea.width / 2, rectTransform.sizeDelta.y);
                InputField_T.transform.position = new Vector3(InputField_T.transform.position.x - rectTransform.sizeDelta.x / 2, InputField_T.transform.position.y, InputField_T.transform.position.z);


            }

            var var_InputField_R = GameObject.Find("InputField_R");
            if (var_InputField_R != null)
            {
                InputField InputField_R = var_InputField_R.GetComponent<InputField>();
                InputField_R.transform.position = new Vector3(0, 0, 0) + InputField_R.transform.parent.position;
                var rectTransform = InputField_R.GetComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(viewArea.width / 2, rectTransform.sizeDelta.y);
                InputField_R.transform.position = new Vector3(InputField_R.transform.position.x + rectTransform.sizeDelta.x / 2, InputField_R.transform.position.y, InputField_R.transform.position.z);

            }

            GUI.EndGroup();

            //#region area3
            text =
              @"T = Período de Translação dos planetas (Em anos)
R = Raio médio das órbitas planetárias (Em UA)
k = Constante";
            Rect viewArea3 = viewArea;
            viewArea3.height = viewArea.height * 2 / qtDivisoes;
            viewArea3.x = viewArea.x;
            viewArea3.y = viewArea2.y + viewArea2.height;
            GUI.BeginGroup(viewArea3);
            var posicao3 = new Rect(posicaoX, posicaoY, viewArea3.width, viewArea3.height);
            GUI.Label(posicao3, text);
            GUI.EndGroup();
        }

        private void SubmitNameInputField_T(string arg0)
        {
            try
            {
                double valor = double.Parse(arg0);
                double resultado = Math.Pow(valor, 2);
                double umTerco = 1d / 3d;
                resultado = Math.Pow(resultado, umTerco);
                var var_InputField = GameObject.Find("InputField_R");
                if (var_InputField != null)
                {
                    InputField InputField = var_InputField.GetComponent<InputField>();
                    InputField.text = resultado.ToString();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }


        private void SubmitNameInputField_R(string arg0)
        {
            try
            {
                double valor = double.Parse(arg0);
                double resultado = Math.Pow(valor, 3);
                resultado = Math.Sqrt(resultado);
                var var_InputField = GameObject.Find("InputField_T");
                if (var_InputField != null)
                {
                    InputField InputField = var_InputField.GetComponent<InputField>();
                    InputField.text = resultado.ToString();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
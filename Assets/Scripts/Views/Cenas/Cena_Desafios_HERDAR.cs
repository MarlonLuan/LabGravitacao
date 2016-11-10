﻿using UnityEngine;
using System.Collections;
using MLFramework_Models = MarlonLuan.MLFramework.Unity.Scripts.Models;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_Desafios_HERDAR : MCena
    {
        private Rect viewArea;
        private float posicaoX = 0;
        private float posicaoY;
        public float velocidade = 29.0f;
        public string text = "";

        // Use this for initialization
        void Start()
        {
            //base.Start();
            viewArea = MenuVertical.fundoMenu;
            posicaoY = viewArea.height;
            text = Auxiliar.LerArquivo(ModeloContextoCena.Id);
        }

        // Update is called once per frame
        void Update()
        {
            posicaoY -= Time.deltaTime * velocidade;
            if (posicaoY < 0) posicaoY = 0;
        }

        new void OnGUI()
        {
            GUI.Box(Cena1Coluna.fundoMenu, SceneManager.GetActiveScene().name);

            GUI.BeginGroup(viewArea);
            var posicao = new Rect(posicaoX + 1, posicaoY, viewArea.width, viewArea.height);

            GUI.Label(posicao, text);

            GUI.EndGroup();

            if (GUI.Button(Menu1Coluna.fundoBotaoLista[Menu1Coluna.fundoBotaoLista.Count - 1], Constantes.Label_Resposta))
            {
                text = Auxiliar.LerArquivo(ModeloContextoCena.Id + Constantes.Label_Resposta);
            }
        }
    }
}
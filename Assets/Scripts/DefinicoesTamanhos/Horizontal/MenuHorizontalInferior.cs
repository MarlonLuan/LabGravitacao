using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public class MenuHorizontalInferior : MenuOpcoes
    {
        ////////// Definiçao da posicao e do tamanho do MENU (centralizando)
        // variavel do tipo float e a aceita como parametro na criaçao do retangulo	
        public static float tamanhoLarguraFundoMenuInferior = Screen.width;
        public static float tamanhoAlturaFundoMenuInferior = Screen.height / 10;
        public static float posicaoEsquerdaFundoMenuInferior = 0;
        public static float posicaoTopoFundoMenuInferior = Screen.height - tamanhoAlturaFundoMenuInferior;

        ////////// Definiçao do tamanho e da posicao do MENU (1 coluna)	
        public static float tamanhoLarguraBotaoMenuInferior = Screen.width / 9; //	= tamanhoLarguraFundoMenu / 3; 
        public static float tamanhoAlturaBotaoMenuInferior = Screen.height / 12; // = tamanhoAlturaFundoMenu / 9;
        public static float posicaoEsquerdaBotaoMenuInferior = 0;
        //public static float posicaoTopoBotaoMenuInferior = Screen.height / 6;
        public static float posicaoTopoBotaoMenuInferior = posicaoTopoFundoMenuInferior + (tamanhoAlturaFundoMenuInferior - tamanhoAlturaBotaoMenuInferior) / 2;

        ////////// Criando retangulos para botoes MENU (5 botoes)
        public static Rect fundoMenu = new Rect(posicaoEsquerdaFundoMenuInferior, posicaoTopoFundoMenuInferior, tamanhoLarguraFundoMenuInferior, tamanhoAlturaFundoMenuInferior);
        public static Rect fundoBotaoInferior1 = new Rect(posicaoEsquerdaBotaoMenuInferior + 1 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior2 = new Rect(posicaoEsquerdaBotaoMenuInferior + 2 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior3 = new Rect(posicaoEsquerdaBotaoMenuInferior + 3 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior4 = new Rect(posicaoEsquerdaBotaoMenuInferior + 4 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior5 = new Rect(posicaoEsquerdaBotaoMenuInferior + 5 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior6 = new Rect(posicaoEsquerdaBotaoMenuInferior + 6 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        public static Rect fundoBotaoInferior7 = new Rect(posicaoEsquerdaBotaoMenuInferior + 7 * (10 + tamanhoLarguraBotaoMenuInferior), posicaoTopoBotaoMenuInferior, tamanhoLarguraBotaoMenuInferior, tamanhoAlturaBotaoMenuInferior);
        //////////////////////////////////////////////////*/
    }
}
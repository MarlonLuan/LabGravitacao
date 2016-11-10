using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public class CenaVertical : MenuOpcoes
    {
        ////////// Definiçao da posicao e do tamanho do MENU (centralizando)
        // variavel do tipo float e a aceita como parametro na criaçao do retangulo
        public static float espacoBorda = Screen.width * 5 / 100;

        public static float tamanhoLarguraFundoMenu = Screen.width - espacoBorda;
        public static float tamanhoAlturaFundoMenu = (Screen.height - MenuHorizontalInferior.tamanhoAlturaFundoMenuInferior) - espacoBorda;
        public static float posicaoEsquerdaFundoMenu = (Screen.width - tamanhoLarguraFundoMenu) / 2; //centralizar horizontal
        public static float posicaoTopoFundoMenu = (Screen.height - tamanhoAlturaFundoMenu - MenuHorizontalInferior.tamanhoAlturaFundoMenuInferior) / 2; //centralizar vertical

        ////////// Definiçao do tamanho e da posicao do MENU (1 coluna)	
        public static float tamanhoLarguraBotaoMenu = Screen.width / 9 * 2; //	= tamanhoLarguraFundoMenu / 3; 
        public static float tamanhoAlturaBotaoMenu = Screen.height / 12; // = tamanhoAlturaFundoMenu / 9;

        public static Rect fundoMenu = new Rect(posicaoEsquerdaFundoMenu, posicaoTopoFundoMenu, tamanhoLarguraFundoMenu, tamanhoAlturaFundoMenu);
    }
}
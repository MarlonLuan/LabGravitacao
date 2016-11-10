using System.Collections.Generic;
using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public class Menu1Coluna : MenuVertical
    {
        public static float posicaoEsquerdaBotaoMenu = (Screen.width - tamanhoLarguraBotaoMenu) / 2;

        ////////// Criando retangulos para botoes MENU (7 botoes)
        public static Rect fundoBotao1 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 1 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao2 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 2 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao3 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 3 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao4 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 4 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao5 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 5 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao6 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 6 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        public static Rect fundoBotao7 = new Rect(posicaoEsquerdaBotaoMenu, posicaoTopoFundoMenu + 7 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);
        //////////////////////////////////////////////////

        public static List<Rect> fundoBotaoLista = new List<Rect> {
            fundoBotao1,
            fundoBotao2,
            fundoBotao3,
            fundoBotao4,
            fundoBotao5,
            fundoBotao6,
            fundoBotao7
        };
    }
}
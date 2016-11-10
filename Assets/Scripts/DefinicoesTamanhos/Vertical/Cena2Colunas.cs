using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public class Cena2Colunas : MenuVertical
    {
        ////////// Definiçao do tamanho e da posicao do MENU (2 colunas)
        // Definiçao do tamanho e da posicao da 1a coluna do MENU
        public static float tamanhoLarguraLabelMenu = tamanhoLarguraBotaoMenu;
        public static float tamanhoAlturaLabelMenu = tamanhoAlturaBotaoMenu / 2;
        public static float posicaoEsquerdaLabelMenu = Screen.width / 3;

        // Definiçao do tamanho e da posicao da 2a coluna do MENU
        public static float tamanhoLarguraValorMenu = tamanhoLarguraBotaoMenu;
        public static float tamanhoAlturaValorMenu = tamanhoAlturaBotaoMenu / 2;
        public static float posicaoEsquerdaValorMenu = Screen.width / 2;
        //////////////////////////////////////////////////

        ////////// Criando retangulos para 2 colunas
        public static Rect fundo2Colunas1A = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 1 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundo2Colunas1B = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 2 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundo2Colunas1C = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 3 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundo2Colunas1D = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 4 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundo2Colunas1E = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 5 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundo2Colunas2A = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 1 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);
        public static Rect fundo2Colunas2B = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 2 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);
        public static Rect fundo2Colunas2C = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 3 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);

        //public static const Rect fundoCalcular = new Rect (posicaoEsquerdaBotaoMenu, posicaoTopoBotaoMenu + 4 * (10 + tamanhoAlturaBotaoMenu), tamanhoLarguraBotaoMenu, tamanhoAlturaBotaoMenu);

        public static Rect fundoLabelDelta = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 6 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundoValorDelta = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 6 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);
        public static Rect fundoLabelX1 = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 7 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundoValorX1 = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 7 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);
        public static Rect fundoLabelX2 = new Rect(posicaoEsquerdaLabelMenu, posicaoTopoFundoMenu + 8 * (10 + tamanhoAlturaLabelMenu), tamanhoLarguraLabelMenu, tamanhoAlturaLabelMenu);
        public static Rect fundoValorX2 = new Rect(posicaoEsquerdaValorMenu, posicaoTopoFundoMenu + 8 * (10 + tamanhoAlturaValorMenu), tamanhoLarguraValorMenu, tamanhoAlturaValorMenu);
        public static Rect fundoCreditos = new Rect(fundoMenu);
    }
}
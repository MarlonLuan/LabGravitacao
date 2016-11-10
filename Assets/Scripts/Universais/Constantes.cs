namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public static class Constantes
    {
        private static string FirstName = "Marlon";
        public static string Autor = FirstName + " Luan Ferreira Nascimento";
        private static string SiglaFaculdade = "UCL";
        public static string Faculdade = "Faculdade do Centro Leste" + " - " + SiglaFaculdade;

        //////////////////////////////////////////////////
        /// 
        /// ~ TESTE ~
        /// TELA INICIAL
        /// LOGIN
        /// MENU GERAL (MENU)
        /// MENU PRINCIPAL (MENU)
        ///  - CONTEÚDO (MENU)
        ///       - SISTEMA SOLAR
        ///       - 1ª LEI DE KEPLER
        ///       - 2ª LEI DE KEPLER
        ///       - 2ª LEI DE KEPLER
        ///       - LEI DA GRAVITAÇÃO UNIVERSAL
        ///       - CONVERSOR
        ///       - VOLTAR
        ///  - DESAFIOS (MENU)
        ///       - DESAFIO1
        ///       - ...
        ///       - ...
        ///       - ...
        ///       - VOLTAR
        ///  - CURIOSIDADES
        ///  - CONFIGURACOES
        ///  - AJUDA (MENU)
        ///       - SOBRE
        ///       - CREDITOS
        ///  - SAIR
        /// 
        //////////////////////////////////////////////////


        /// <summary>
        /// 
        /// </summary>
        //public const string Cena_LabMatika = "LabMatika";


        public static User usuarioLogado = new User() { ID = 1, Idade = 1, Nome = "Aluno"};

        public const string Id_TelaInicial = "TelaInicial";
        public const string Id_MenuLogin = "Login";
        public const string Id_MenuGeral = "MenuGeral";
        public const string Id_MenuPrincipal = "MenuPrincipal";

        //public const string Label_LabGravitacao = "LabGravitacao";
        public const string Label_TelaInicial = "Tela Inicial";
        public const string Label_MenuLogin = "Login";
        public const string Label_MenuGeral = "Geral";
        public const string Label_MenuPrincipal = "Menu Principal";

        //public const string Help_LabGravitacao = "AJUDA: LabGravitacao";
        public const string Help_TelaInicial = "AJUDA: Tela Inicial";
        public const string Help_MenuLogin = "AJUDA: Login";
        public const string Help_MenuGeral = "AJUDA: Geral";
        public const string Help_MenuPrincipal = "AJUDA: Menu Principal";


        /// <summary>
        /// EXERCÍCIOS
        /// </summary>
        public const string Id_MenuConteudo = "MenuConteudo";
        //public const string Id_SistemaSolar = "SistemaSolar";
        public const string Id_SistemaSolar = "solar system";
        public const string Id_PrimeriaLeiKepler = "PrimeiraLeiKepler";
        public const string Id_SegundaLeiKepler = "SegundaLeiKepler";
        public const string Id_TerceiraLeiKepler = "TerceiraLeiKepler";
        public const string Id_LeiGravitacaoUniversal = "LeiGravitacaoUniversal";
        public const string Id_Conversor = "Conversor";

        public const string Label_MenuConteudo = "Conteúdo";
        public const string Label_SistemaSolar = "Sistema Solar";
        public const string Label_PrimeiraLeiKepler = "1ª Lei de Kepler";
        public const string Label_SegundaLeiKepler = "2ª Lei de Kepler";
        public const string Label_TerceiraLeiKepler = "3ª Lei de Kepler";
        public const string Label_LeiGravitacaoUniversal = "Lei da Gravitação Universal";
        public const string Label_Conversor = "Conversor de Medidas";

        public const string Help_MenuConteudo = "AJUDA: Conteúdo";
        public const string Help_SistemaSolar = "AJUDA: Sistema Solar";
        public const string Help_PrimeiraLeiKepler = "AJUDA: 1ª Lei de Kepler";
        public const string Help_SegundaLeiKepler = "AJUDA: 2ª Lei de Kepler";
        public const string Help_TerceiraLeiKepler = "AJUDA: 3ª Lei de Kepler";
        public const string Help_LeiGravitacaoUniversal = "AJUDA: Lei da Gravitação Universal";
        public const string Help_Conversor = "AJUDA: Conversor de Medidas";


        /// <summary>
        /// DESAFIOS
        /// </summary>
        public const string Id_MenuDesafios = "MenuDesafios";
        public const string Id_Desafio1 = "Desafio1";
        public const string Id_Desafio2 = "Desafio2";
        public const string Id_Desafio3 = "Desafio3";
        public const string Id_Desafio4 = "Desafio4";
        public const string Id_Desafio5 = "Desafio5";
        public const string Id_Desafio6 = "Desafio6";

        public const string Label_MenuDesafios = "Desafios";
        public const string Label_Desafio1 = "Desafio 1";
        public const string Label_Desafio2 = "Desafio 2";
        public const string Label_Desafio3 = "Desafio 3";
        public const string Label_Desafio4 = "Desafio 4";
        public const string Label_Desafio5 = "Desafio 5";
        public const string Label_Desafio6 = "Desafio 6";

        public const string Help_MenuDesafios = "AJUDA: Desafios";
        public const string Help_Desafio1 = "AJUDA: Desafio 1";
        public const string Help_Desafio2 = "AJUDA: Desafio 2";
        public const string Help_Desafio3 = "AJUDA: Desafio 3";
        public const string Help_Desafio4 = "AJUDA: Desafio 4";
        public const string Help_Desafio5 = "AJUDA: Desafio 5";
        public const string Help_Desafio6 = "AJUDA: Desafio 6";


        /// <summary>
        /// CURIOSIDADES
        /// </summary>
        public const string Id_MenuCuriosidades = "MenuCuriosidades";
        public const string Id_Curiosidade1 = "Curiosidade1";
        public const string Id_Curiosidade2 = "Curiosidade2";

        public const string Label_MenuCuriosidades = "Curiosidades";
        public const string Label_Curiosidade1 = "Curiosidade 1";
        public const string Label_Curiosidade2 = "Curiosidade 2";

        public const string Help_MenuCuriosidades = "AJUDA: Curiosidades";
        public const string Help_Curiosidade1 = "AJUDA: Curiosidade 1";
        public const string Help_Curiosidade2 = "AJUDA: Curiosidade 2";


        /// <summary>
        /// CONFIGURAÇÕES
        /// </summary>
        public const string Id_Configuracoes = "Configuracoes";
        public const string Label_Configuracoes = "Configurações";
        public const string Help_Configuracoes = "AJUDA: Configurações";


        /// <summary>
        /// AJUDA
        /// </summary>
        public const string Id_MenuAjuda = "MenuAjuda";
        public const string Id_Creditos = "Creditos";
        public const string Id_Sobre = "Sobre";

        public const string Label_MenuAjuda = "Ajuda";
        public const string Label_Creditos = "Créditos";
        public const string Label_Sobre = "Sobre";

        public const string Help_MenuAjuda = "AJUDA: Ajuda";
        public const string Help_Creditos = "AJUDA: Créditos";
        public const string Help_Sobre = "AJUDA: Sobre";


        /// <summary>
        /// SAIR
        /// </summary>
        public const string Id_Sair = "Sair";
        public const string Label_Sair = "Sair";
        public const string Help_Sair = "AJUDA: Sair";


        /// <summary>
        /// /////////////////////////
        /// </summary>
        public const string Id_MenuAtalho = "MenuAtalho";
        public const string Label_MenuAtalho = "Menu Atalho";
        public const string Help_MenuAtalho = "AJUDA: Menu Atalho";
        //
        //
        public const string Id_Entrar = "Entrar";
        public const string Id_Voltar = "Voltar";
        public const string Id_Calcular = "Calcular";
        //
        //
        public const string Label_Entrar = "Entrar";
        public const string Label_Voltar = "Voltar";
        public const string Label_Calcular = "Calcular";
        public const string Label_VazioTeste = "---ZZZ---";
        public const string Label_Empty = "";

        public const string Label_Pergunta = "Pergunta";
        public const string Label_Resposta = "Resposta";
        //        
        //
        public const string Help_Entrar = "AJUDA: Entrar";
        public const string Help_Voltar = "AJUDA: Voltar";
        public const string Help_Calcular = "AJUDA: Calcular";

        ////////////////////////////// LOGs
        //
        public const string Log_ClickBotao = "Clicou no Botão: ";
        public const string Log_CarregarCena = "Carregou Cena: ";
        public const string Log_Comando = "Comando: ";
        public const string Log_Logar = "Logou";
        public const string Log_Sair = "Sair";

        public static string CenaAnterior = "";
        //public static MenuEnum MenuQueFoiSelecionadoTemporario;

        //public static string caminhoTexto = @"E:\OneDrive\Documentos\Projetos\Unity\LabGravitacao\Assets\Textos\";
        public static string caminhoTexto = @"Assets\Textos\";
        public static bool PermitidoAtalho = true;

        public static float excentricidade = 0.90f;
        //public static string caminhoTexto = @"";
    }
}

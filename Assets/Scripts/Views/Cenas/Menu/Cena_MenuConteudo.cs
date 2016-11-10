namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_MenuConteudo : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new Models.MenuConteudo();
            ModeloContextoCena.FundoMenu = MenuVertical.fundoMenu;
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuConteudo;
        }
    }
}
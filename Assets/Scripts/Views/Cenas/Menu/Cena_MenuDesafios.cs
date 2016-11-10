namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_MenuDesafios : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new Models.MenuDesafios();
            ModeloContextoCena.FundoMenu = MenuVertical.fundoMenu;
            //Constantes.MenuQueFoiSelecionadoTemporario = MenuEnum.MenuDesafios;
        }
    }
}
namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_MenuPrincipal : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new Models.MenuPrincipal();
            ModeloContextoCena.FundoMenu = MenuVertical.fundoMenu;
        }
    }
}
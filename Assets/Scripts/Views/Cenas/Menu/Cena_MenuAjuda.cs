namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_MenuAjuda : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new Models.MenuAjuda();
            ModeloContextoCena.FundoMenu = MenuVertical.fundoMenu;
        }
    }
}
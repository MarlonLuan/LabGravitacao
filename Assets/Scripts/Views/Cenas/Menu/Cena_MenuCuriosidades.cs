namespace MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas
{
    public class Cena_MenuCuriosidades : MCena
    {
        void Awake()
        {
            ModeloContextoCena = new Models.MenuCuriosidades();
            ModeloContextoCena.FundoMenu = MenuVertical.fundoMenu;
        }
    }
}
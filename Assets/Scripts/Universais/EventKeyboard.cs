using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public class EventKeyboard : MonoBehaviour
    {
        public string idCenaAnterior = Constantes.Id_MenuPrincipal;

        void OnGUI()
        {
            if (Constantes.PermitidoAtalho)
            {

                if (Event.current.Equals(Event.KeyboardEvent("backspace")))
                    SceneManager.LoadScene(idCenaAnterior, LoadSceneMode.Single);


                if (Event.current.Equals(Event.KeyboardEvent("A")))
                    SceneManager.LoadScene(Constantes.Id_MenuAjuda, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("C")))
                    SceneManager.LoadScene(Constantes.Id_MenuConteudo, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("D")))
                    SceneManager.LoadScene(Constantes.Id_MenuConteudo, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("G")))
                    SceneManager.LoadScene(Constantes.Id_LeiGravitacaoUniversal, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("L")))
                    SceneManager.LoadScene(Constantes.Id_MenuLogin, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("M")))
                    SceneManager.LoadScene(Constantes.Id_MenuPrincipal, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("P")))
                    SceneManager.LoadScene(Constantes.Id_PrimeriaLeiKepler, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("S")))
                    SceneManager.LoadScene(Constantes.Id_SegundaLeiKepler, LoadSceneMode.Single);

                if (Event.current.Equals(Event.KeyboardEvent("T")))
                    SceneManager.LoadScene(Constantes.Id_TerceiraLeiKepler, LoadSceneMode.Single);

            }
        }
    }
}

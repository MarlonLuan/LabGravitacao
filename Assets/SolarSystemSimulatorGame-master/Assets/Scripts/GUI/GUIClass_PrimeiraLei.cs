using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using MarlonLuan.MLFramework.Unity.Scripts;

public class GUIClass_PrimeiraLei : MonoBehaviour
{
    public static Queue<string> messageQueue = new Queue<string>();
    bool messageIsBeingDisplayed = false;
    string messageToBeDisplayed;

    private const string excentricidadeMessage = "Defina a excentricidade na tela de configuração.";

    bool gravityMultiplierMessageIsDisplayed = false;
    [System.Flags]
    enum Buttons
    {
        planetsButton = 0x001,  // 000000000001
        objectivesButton = 0x002,  // 000000000010
        spaceCraftButton = 0x004,  // 000000000100
        launchSpaceCraftButton = 0x008,
        vikingButton = 0x010,
        magellanButton = 0x020,
        galileoButton = 0x040,
        genericButton = 0x080,
        courseCorrectionButton = 0x100,
        settingsButton = 0x200,
        gravityButton = 0x400,
        creditsButton = 0x800
    }
    ;
    Buttons buttonStatus;
    public GUISkin customSkin;
    private float hScrollbarDirection;
    private float hScrollbarSpeed;
    private float gravitySlider = Constantes.eccentricity;
    public Texture2D plusIcon;
    public Texture2D minusIcon;
    public Texture2D playIcon;
    public Texture2D stopIcon;
    private float offSetX = 30;
    private float offSetY = 30;
    float offX = 10;
    float offY;
    float width;
    private float y1 = 5;
    private float y2 = 25;
    private CamController camCon;
    private SpaceCraft selectedSc;
    private List<Planet> planetList;
    private AuxOrbit auxOrbit;
    GUIStyle style = new GUIStyle();
    private Scales.GravityLevel gravityLevel0 = Scales.GravityLevel.normal;

    void Start()
    {
        camCon = Camera.main.GetComponent<CamController>();

        planetList = Planet.planetList;

        auxOrbit = GameObject.Find("AuxOrbit").GetComponent<AuxOrbit>();

        //messageQueue.Enqueue(excentricidadeMessage);


    }

    void Update()
    {
        //
        Scales.ClampTimeScale();

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            Scales.IncreaseTimeScale();
        }

        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            Scales.DecreaseTimeScale();
        }

        if (Input.GetKeyDown("space"))
        {
            Scales.Pause = !Scales.Pause;
        }
        /******************************************************************************************************************/
        if (messageQueue.Count != 0 && messageIsBeingDisplayed == false)
        {
            messageToBeDisplayed = messageQueue.Dequeue();
            StartCoroutine(CountdownForMessage(Scales.messageDurationPrimeiraLei));
        }
        /******************************************************************************************************************/
        gravityLevel0 = Scales.GravityLevel.normal;
        foreach (SpaceCraft sc in SpaceCraft.spaceCraftList)
        {
            if (sc.sco.gravityLevel > gravityLevel0)
                gravityLevel0 = sc.sco.gravityLevel;

            if (sc.IsSelected == true)
            {
                if (selectedSc != null && selectedSc != sc)
                    selectedSc.isCourseCorrecting = false;

                selectedSc = sc;
            }
        }


    }

    void OnGUI()
    {
        GUI.skin = customSkin;

        offX = 10;
        width = 0;

        if (GUI.Button(new Rect(offX, y1, playIcon.width, y2), playIcon))
        {
            Scales.Pause = false;
        }
        offX += playIcon.width;

        if (GUI.Button(new Rect(offX, y1, stopIcon.width, y2), stopIcon))
        {
            Scales.Pause = true;
        }
        offX += stopIcon.width + 10f;

        if (GUI.Button(new Rect(offX, y1, minusIcon.width, y2), minusIcon))
        {
            Scales.DecreaseTimeScale();
        }
        offX += minusIcon.width;

        if (GUI.Button(new Rect(offX, y1, plusIcon.width, y2), plusIcon))
        {
            Scales.IncreaseTimeScale();
        }
        offX += plusIcon.width;

        if (Scales.Pause == false)
            GUI.Label(new Rect(offX, y1, Screen.width, Screen.height), "x" + Scales.CurrentTimeScale.ToString());
        else
            GUI.Label(new Rect(offX, y1, Screen.width, Screen.height), "pausado");
        offX += width + 50f;



        width = 100f;
        if (GUI.Button(new Rect(Screen.width - width - offSetX, y1, width, y2), "Configurações") && messageIsBeingDisplayed == false)
        {
            buttonStatus ^= Buttons.settingsButton;
            buttonStatus &= Buttons.settingsButton;
        }
        if (buttonStatus == Buttons.settingsButton)
        {
            if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + offSetY, width, y2), "Excentricidade"))
            {
                buttonStatus ^= Buttons.gravityButton;
                buttonStatus &= Buttons.gravityButton;
            }
        }
        if (buttonStatus == Buttons.gravityButton)
        {
            gravitySlider = GUI.HorizontalScrollbar(new Rect(Screen.width - width - offSetX, y1 + offSetY, width, y2),
                                    gravitySlider, 0f, 0f, 0.9f);

            string labelDirection = gravitySlider.ToString();
            GUI.Label(new Rect(Screen.width - offSetX, y1 + offSetY - 3, 140, 30), labelDirection);

            if (gravityMultiplierMessageIsDisplayed == false)
            {
                gravityMultiplierMessageIsDisplayed = true;
                messageQueue.Enqueue(excentricidadeMessage);
            }

            if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + 2 * offSetY, width, y2), "Definir"))
            {
                foreach (SpaceCraft sc in SpaceCraft.spaceCraftList)
                    Destroy(sc.gameObject);
                SpaceCraft.spaceCraftList.Clear();

                Constantes.eccentricity = gravitySlider;
                SceneManager.LoadScene(Constantes.Id_PrimeriaLeiKepler);
                buttonStatus = 0;
            }
        }
        else
            gravitySlider = Scales.massScale;



    }



    IEnumerator CountdownForMessage(float time0)
    {
        for (float timer = time0; timer >= 0; timer -= Time.deltaTime)
        {
            Scales.Pause = true;
            Scales.ResetTimeScale();
            messageIsBeingDisplayed = true;
            yield return null;
        }
        messageIsBeingDisplayed = false;
    }

    void ShowPlanets()
    {
        for (int i = 0; i < planetList.Count; i++)
            if (GUI.Button(new Rect(offX, y1 + offSetY * (i + 1), width, y2), planetList[i].gameObject.name))
                camCon.LockObject(planetList[i].gameObject.transform);
    }

    void ShowLaunchPanel(float minDirection, float maxDirection, float minSpeed, float maxSpeed, string label)
    {
        offY += offSetY;
        hScrollbarDirection = GUI.HorizontalScrollbar(new Rect(offX, y1 + offSetY, 170, 30),
                                                hScrollbarDirection, 0f, minDirection, maxDirection);

        string labelDirection = Mathf.Round(hScrollbarDirection).ToString() + "°";
        GUI.Label(new Rect(offX + width, y1 + offSetY - 3, 140, 30), labelDirection);

        offY += offSetY;
        hScrollbarSpeed = GUI.HorizontalScrollbar(new Rect(offX, y1 + 2 * offSetY, 170, 30),
                                                hScrollbarSpeed, 0.0f, minSpeed, maxSpeed);

        string labelSpeed = (Mathf.Round(hScrollbarSpeed * Scales.velmu2kms * 100f) / 100f).ToString() + "km/s";
        GUI.Label(new Rect(offX + width, y1 + 2 * offSetY - 3, 140, 30), labelSpeed);

        offY += offSetY;
        if (GUI.Button(new Rect(offX, y1 + 3 * offSetY, 170, 30), "Lançar " + label))
        {
            MissileManager.instance.LaunchSpaceCraft(hScrollbarSpeed, hScrollbarDirection, label);
            buttonStatus = 0;

            hScrollbarDirection = 0;
            hScrollbarSpeed = 0;

            auxOrbit.isActive = false;
            auxOrbit.POPlanet = null;
        }

        auxOrbit.Speed = hScrollbarSpeed;
        auxOrbit.Direction = hScrollbarDirection;
    }


    private float AngleBetween(Vector3 a, Vector3 b, Vector3 n)
    {
        return Vector3.Angle(a, b) * Mathf.Sign(Vector3.Dot(n, Vector3.Cross(a, b)));
    }
}
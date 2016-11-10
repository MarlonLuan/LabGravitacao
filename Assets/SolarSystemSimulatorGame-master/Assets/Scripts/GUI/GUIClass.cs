using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using MarlonLuan.MLFramework.Unity.Scripts;

public class GUIClass : MonoBehaviour
{
	public static Queue<string> messageQueue = new Queue<string> ();
	bool messageIsBeingDisplayed = false;
	string messageToBeDisplayed;
    /*
	private const string initialMessage = "This is a both a Game and a Simulation of our Solar System. \n" +
		"The planets the moon and the Space Crafts follow realistic orbits\n" +
		" and the relative sizes of the planets and moon are correct.";
	private const string secondMessage = "The goal of the Game is to launch Space Crafts and complete all the missions.";
	private const string thirdMessage = "Controls \n" +
		"Right click & move: rotate\n" +
		"Wheel: zoom in/out\n" +
		"Click on object to get info\n" +
		"Double click to focus.";
	private const string creditsMessage = "Version 1.02 \n\n Programmer: Sotos\n\n Music: Comfortable Mystery, incompetech.com";
	private const string controlsMessage1 = "Right click & move: rotate\n" +
		"Wheel: zoom in/out\n" +
		"Click on object to get info\n" +
		"Double click to focus\n";
	private const string controlsMessage2 = 
        "Press Del to remove a Space Craft.\n" +
		"Press + - spacebar to manage time.";
	private const string strongGravityMessage = "One of your Space Crafts is approaching a strong gravity field. When this happens, time will scale accordingly";
	private bool strongGravityMessageQueued = false;
	private const string gravityMultiplierMessage = "This sets the strength of the Gravitational field of the planets. If you press Set " +
		"all objectives will reset and all Space Crafts will be removed.";
	bool gravityMultiplierMessageIsDisplayed = false;
    */
    
    private const string initialMessage = "Este é um jogo e uma simulação do nosso Sistema Solar. \n" +
                                            "Os planetas da Lua e espaçonaves seguem órbitas realistas.\n" +
                                            "E os tamanhos relativos dos planetas e da lua estão corretos.";
    private const string secondMessage = "O objetivo do Jogo é lançar espaçonaves e completar todas as missões.";
    private const string thirdMessage = "Controles \n" +
                                        "Botão direito mouse & mover: rotacionar\n" +
                                        "Scroll mouse: zoom in/out\n" +
                                        "Clique no planeta para informações\n" +
                                        "Duplo clique para focar.";
    private const string creditsMessage = "Versão 1.02 \n\n Programador: Sotos\n\n Música: Comfortable Mystery, incompetech.com \n Adaptado";
    private const string controlsMessage1 =
                                        "Botão direito mouse & mover: rotacionar\n" +
                                        "Scroll mouse: zoom in/out\n" +
                                        "Clique no planeta para informações\n" +
                                        "Duplo clique para focar.";
    private const string controlsMessage2 =
                                            "Pressione Del para remover espaçonave.\n" +
                                            "Pressione + - barra espaço para gerenciar o tempo.";
    private const string strongGravityMessage = "Uma de suas espaçonaves está se aproximando de um campo de gravidade forte. Quando isso acontece, o tempo será dimensionado de acordo";
    private bool strongGravityMessageQueued = false;
    private const string gravityMultiplierMessage = "Isso define a força do campo gravitacional dos planetas. Se você pressionar \"Definir\" " +
                                                     "Todos os objetivos serão redefinidos e todas as espaçonaves serão removidos.";
    private const string excentricidadeMessage = "Defina a excentricidade na tela de configuração.";

    bool gravityMultiplierMessageIsDisplayed = false;
    [System.Flags]
	enum Buttons
	{
		planetsButton =             0x001,  // 000000000001
		objectivesButton =          0x002,  // 000000000010
		spaceCraftButton =          0x004,  // 000000000100
		launchSpaceCraftButton =    0x008,  
		vikingButton =              0x010,  
		magellanButton =            0x020,
		galileoButton =             0x040,
		genericButton =             0x080,  
		courseCorrectionButton =    0x100,
		settingsButton =            0x200,
		gravityButton =             0x400,
		creditsButton =             0x800
    }
	;
	Buttons buttonStatus;
	public GUISkin customSkin;
	private float hScrollbarDirection;
	private float hScrollbarSpeed;
	private float gravitySlider = Scales.massScale;
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
	GUIStyle style = new GUIStyle ();
	private Scales.GravityLevel gravityLevel0 = Scales.GravityLevel.normal;

    void Start()
    {
        camCon = Camera.main.GetComponent<CamController>();

        planetList = Planet.planetList;

        auxOrbit = GameObject.Find("AuxOrbit").GetComponent<AuxOrbit>();

        if (SceneManager.GetActiveScene().name != Constantes.Id_PrimeriaLeiKepler)
        {
            messageQueue.Enqueue(initialMessage);
            messageQueue.Enqueue(secondMessage);
            messageQueue.Enqueue(thirdMessage);
        }
        else
        {
            //messageQueue.Enqueue(excentricidadeMessage);

        }
	}

	void Update ()
	{
		//
		Scales.ClampTimeScale ();

		if (Input.GetKeyDown (KeyCode.KeypadPlus)) {
			Scales.IncreaseTimeScale ();
		}
		
		if (Input.GetKeyDown (KeyCode.KeypadMinus)) {
			Scales.DecreaseTimeScale ();
		}

		if (Input.GetKeyDown ("space")) {
			Scales.Pause = !Scales.Pause;
		}
/******************************************************************************************************************/
		if (messageQueue.Count != 0 && messageIsBeingDisplayed == false) {
			messageToBeDisplayed = messageQueue.Dequeue ();
			StartCoroutine (CountdownForMessage (Scales.messageDuration));
		}
/******************************************************************************************************************/
		gravityLevel0 = Scales.GravityLevel.normal;
		foreach (SpaceCraft sc in SpaceCraft.spaceCraftList) {
			if (sc.sco.gravityLevel > gravityLevel0)
				gravityLevel0 = sc.sco.gravityLevel;

			if (sc.IsSelected == true) {
				if (selectedSc != null && selectedSc != sc)
					selectedSc.isCourseCorrecting = false;

				selectedSc = sc;
			}
		}

		if (gravityLevel0 != Scales.GravityLevel.normal && strongGravityMessageQueued == false) {
			strongGravityMessageQueued = true;
			messageQueue.Enqueue (strongGravityMessage);
		}

		switch (gravityLevel0) {
		case Scales.GravityLevel.normal:
			Scales.ResetMaximumTimeScale ();
			break;
		case Scales.GravityLevel.medium:
			Scales.MaxTimeScale = 1;
			break;
		case Scales.GravityLevel.high:
			Scales.MaxTimeScale = 0.5f;
			break;
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


        if (SceneManager.GetActiveScene().name != Constantes.Id_PrimeriaLeiKepler)
        {
            width = 100f;
            if (GUI.Button(new Rect(offX, y1, width, y2), "Objetivos") && messageIsBeingDisplayed == false)
            {
                buttonStatus ^= Buttons.objectivesButton;
                buttonStatus &= Buttons.objectivesButton;
            }
            if (buttonStatus == Buttons.objectivesButton)
            {
                ShowObjectives();
            }
            offX += width;

            width = 170f;
            if (GUI.Button(new Rect(offX, y1, width, y2), " Espaçonaves ") && messageIsBeingDisplayed == false)
            {
                buttonStatus ^= Buttons.spaceCraftButton;
                buttonStatus &= Buttons.spaceCraftButton;
            }
            if (buttonStatus == Buttons.spaceCraftButton)
            {
                offY = offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Lançar Espaçonaves"))
                {
                    buttonStatus ^= Buttons.launchSpaceCraftButton;
                    buttonStatus &= Buttons.launchSpaceCraftButton;
                }
                offY += offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Correção de Curso"))
                {
                    buttonStatus ^= Buttons.courseCorrectionButton;
                    buttonStatus &= Buttons.courseCorrectionButton;
                }
            }
            if (GUI.Button(new Rect(Screen.width - width - offSetX, y1, width, y2), "Configurações") && messageIsBeingDisplayed == false)
            {
                buttonStatus ^= Buttons.settingsButton;
                buttonStatus &= Buttons.settingsButton;
            }
            if (buttonStatus == Buttons.settingsButton)
            {
                if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + offSetY, width, y2), "Gravidade Múltipla"))
                {
                    buttonStatus ^= Buttons.gravityButton;
                    buttonStatus &= Buttons.gravityButton;
                }
                if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + 2 * offSetY, width, y2), "Créditos"))
                {
                    messageQueue.Enqueue(creditsMessage);
                    buttonStatus = 0;
                }
                if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + 3 * offSetY, width, y2), "Controles"))
                {
                    messageQueue.Enqueue(controlsMessage1);
                    messageQueue.Enqueue(controlsMessage2);
                    buttonStatus = 0;
                }
            }
            if (buttonStatus == Buttons.gravityButton)
            {
                gravitySlider = GUI.HorizontalScrollbar(new Rect(Screen.width - width - offSetX, y1 + offSetY, width, y2),
                                        gravitySlider, 0f, 1, 50);

                string labelDirection = Mathf.Round(gravitySlider).ToString() + "x";
                GUI.Label(new Rect(Screen.width - offSetX, y1 + offSetY - 3, 140, 30), labelDirection);

                if (gravityMultiplierMessageIsDisplayed == false)
                {
                    gravityMultiplierMessageIsDisplayed = true;
                    messageQueue.Enqueue(gravityMultiplierMessage);
                }

                if (GUI.Button(new Rect(Screen.width - width - offSetX, y1 + 2 * offSetY, width, y2), "Definir"))
                {
                    foreach (ObjectiveManager.Objective o in ObjectiveManager.instance.ObjsList)
                        o.isCompleted = false;

                    foreach (SpaceCraft sc in SpaceCraft.spaceCraftList)
                        Destroy(sc.gameObject);
                    SpaceCraft.spaceCraftList.Clear();

                    Scales.massScale = gravitySlider;
                    buttonStatus = 0;
                }
            }
            else
                gravitySlider = Scales.massScale;

            auxOrbit.isActive = false;
            auxOrbit.POPlanet = null;

            if (buttonStatus == Buttons.launchSpaceCraftButton)
            {
                auxOrbit.isActive = false;
                auxOrbit.POPlanet = null;

                offY = offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Lançar Viking"))
                {
                    buttonStatus ^= Buttons.vikingButton;
                    buttonStatus &= Buttons.vikingButton;
                }

                offY += offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Lançar Magellan"))
                {
                    buttonStatus ^= Buttons.magellanButton;
                    buttonStatus &= Buttons.magellanButton;
                }

                offY += offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Lançar Galileo"))
                {
                    buttonStatus ^= Buttons.galileoButton;
                    buttonStatus &= Buttons.galileoButton;
                }

                offY += offSetY;
                if (GUI.Button(new Rect(offX, y1 + offY, width, y2), "Lançar Generic"))
                {
                    buttonStatus ^= Buttons.genericButton;
                    buttonStatus &= Buttons.genericButton;
                }
            }
            if (buttonStatus == Buttons.vikingButton)
            {
                ShowLaunchPanel(0f, 360f, 2.2f * Scales.kms2velmu, 4.0f * Scales.kms2velmu, "Viking");

                auxOrbit.isActive = true;
                auxOrbit.POPlanet = planetList[3].po;
            }
            else if (buttonStatus == Buttons.magellanButton)
            {
                ShowLaunchPanel(0f, 360f, 2.2f * Scales.kms2velmu, 3.6f * Scales.kms2velmu, "Magellan");

                auxOrbit.isActive = true;
                auxOrbit.POPlanet = planetList[1].po;
            }
            else if (buttonStatus == Buttons.galileoButton)
            {
                ShowLaunchPanel(0f, 90f, 8f * Scales.kms2velmu, 9.2f * Scales.kms2velmu, "Galileo");

                auxOrbit.isActive = true;
                auxOrbit.POPlanet = planetList[4].po;
            }
            else if (buttonStatus == Buttons.genericButton)
            {
                if (ObjectiveManager.fiveFirstObjectivesCompleted == true)
                    ShowLaunchPanel(0f, 360f, 0f, 16.3f * Scales.kms2velmu, "Generic");
                else
                {
                    buttonStatus = 0;
                    messageQueue.Enqueue("Complete os 5 primeiros objetivos para desbloquear isso!");
                }
            }
            else if (buttonStatus == Buttons.courseCorrectionButton)
            {
                if (selectedSc != null)
                {
                    selectedSc.isCourseCorrecting = true;
                    if (selectedSc.allowableNumberOfThrusts > 0)
                        ShowCourseCorrectionPanel(0f, 360f, 0f, 16.3f * Scales.kms2velmu);
                    else
                        GUI.Label(new Rect(offX + 50, y1 + offSetY, width, y2), "Sem combustível!");
                }
                else
                    GUI.Label(new Rect(offX + 15, y1 + offSetY, width, y2), "Nenhuma espaçonave selecionada!");
            }

            if (buttonStatus != Buttons.courseCorrectionButton)
                if (selectedSc != null)
                    selectedSc.isCourseCorrecting = false;

            if (messageIsBeingDisplayed == true)
                GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 175), messageToBeDisplayed);
        }
    }

	IEnumerator CountdownForMessage (float time0)
	{
		for (float timer = time0; timer >= 0; timer -= Time.deltaTime) {
			Scales.Pause = true;
			Scales.ResetTimeScale ();
			messageIsBeingDisplayed = true;
			yield return null;
		}
		messageIsBeingDisplayed = false;
	}

	void ShowObjectives ()
	{
		int i = 1;
		foreach (ObjectiveManager.Objective o in ObjectiveManager.instance.ObjsList) {
			if (o.isCompleted == true)
				style.normal.textColor = Color.green;
			else
				style.normal.textColor = Color.red;

			GUI.Label (new Rect (offX, y1 + offSetY * i++, 240, y2), o.ObjectiveGoal, style);
		}
	}

	void ShowPlanets ()
	{
		for (int i = 0; i < planetList.Count; i++)
			if (GUI.Button (new Rect (offX, y1 + offSetY * (i + 1), width, y2), planetList [i].gameObject.name))
				camCon.LockObject (planetList [i].gameObject.transform);
	}

	void ShowLaunchPanel (float minDirection, float maxDirection, float minSpeed, float maxSpeed, string label)
	{
		offY += offSetY;
		hScrollbarDirection = GUI.HorizontalScrollbar (new Rect (offX, y1 + offSetY, 170, 30),
                                                hScrollbarDirection, 0f, minDirection, maxDirection);

		string labelDirection = Mathf.Round (hScrollbarDirection).ToString () + "°";
		GUI.Label (new Rect (offX + width, y1 + offSetY - 3, 140, 30), labelDirection);

		offY += offSetY;
		hScrollbarSpeed = GUI.HorizontalScrollbar (new Rect (offX, y1 + 2 * offSetY, 170, 30),
                                                hScrollbarSpeed, 0.0f, minSpeed, maxSpeed);

		string labelSpeed = (Mathf.Round (hScrollbarSpeed * Scales.velmu2kms * 100f) / 100f).ToString () + "km/s";
		GUI.Label (new Rect (offX + width, y1 + 2 * offSetY - 3, 140, 30), labelSpeed);

		offY += offSetY;
		if (GUI.Button (new Rect (offX, y1 + 3 * offSetY, 170, 30), "Lançar " + label)) {
			MissileManager.instance.LaunchSpaceCraft (hScrollbarSpeed, hScrollbarDirection, label);
			buttonStatus = 0;

			hScrollbarDirection = 0;
			hScrollbarSpeed = 0;

			auxOrbit.isActive = false;
			auxOrbit.POPlanet = null;
		}

		auxOrbit.Speed = hScrollbarSpeed;
		auxOrbit.Direction = hScrollbarDirection;
	}

	void ShowCourseCorrectionPanel (float minDirection, float maxDirection, float minSpeed, float maxSpeed)
	{
		offY += offSetY;
		hScrollbarDirection = GUI.HorizontalScrollbar (new Rect (offX, y1 + offSetY, 170, 30),
                                                hScrollbarDirection, 0f, minDirection, maxDirection);

		string labelDirection = Mathf.Round (hScrollbarDirection).ToString () + "°";
		GUI.Label (new Rect (offX + width, y1 + offSetY - 3, 140, 30), labelDirection);

		offY += offSetY;
		hScrollbarSpeed = GUI.HorizontalScrollbar (new Rect (offX, y1 + 2 * offSetY, 170, 30),
                                                hScrollbarSpeed, 0.0f, selectedSc.minVelForCourseCorrection, selectedSc.maxVelForCourseCorrection);

		string labelSpeed = (Mathf.Round (hScrollbarSpeed * Scales.velmu2kms * 100f) / 100f).ToString () + "km/s";
		GUI.Label (new Rect (offX + width, y1 + 2 * offSetY - 3, 140, 30), labelSpeed);

		selectedSc.angle = hScrollbarDirection;

		offY += offSetY;
		if (GUI.Button (new Rect (offX, y1 + 3 * offSetY, 170, 30), "Thrust")) {
			selectedSc.allowableNumberOfThrusts--;
			selectedSc.Velocity += hScrollbarSpeed * (Quaternion.Euler (0, hScrollbarDirection, 0) * selectedSc.Velocity).normalized;
			hScrollbarDirection = 0;
			hScrollbarSpeed = 0;
		}
	}

	private float AngleBetween (Vector3 a, Vector3 b, Vector3 n)
	{
		return Vector3.Angle (a, b) * Mathf.Sign (Vector3.Dot (n, Vector3.Cross (a, b)));
	}
}
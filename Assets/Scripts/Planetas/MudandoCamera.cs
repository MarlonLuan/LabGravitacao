using UnityEngine;
using System.Collections;

public class MudandoCamera : MonoBehaviour {
	
	public Camera CameraSol; 		// 0
	public Camera CameraMercurio; 	// 1
	public Camera CameraVenus; 		// 2
	public Camera CameraTerra; 		// 3
	public Camera CameraMarte; 		// 4
	public Camera CameraJupiter; 	// 5
	public Camera CameraSaturno; 	// 6
	public Camera CameraUrano; 		// 7
	public Camera CameraNetuno; 	// 8
	public Camera CameraPadrao; 	// 9
			
	// Use this for initialization
	void Start () { 

	CameraSol.enabled 		= false;
	CameraMercurio.enabled 	= false;
	CameraVenus.enabled 	= false;
	CameraTerra.enabled 	= false;
	CameraMarte.enabled 	= false;
	CameraJupiter.enabled 	= false;
	CameraSaturno.enabled 	= false;
	CameraUrano.enabled 	= false;
	CameraNetuno.enabled 	= false;
	CameraPadrao.enabled 	= true;
		
	} 
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown ("0"))
		{ 
			SelecionarCamera(0);
		}
		
		if (Input.GetKeyDown ("1"))
		{ 
			SelecionarCamera(1);
		}
		
		if (Input.GetKeyDown ("2"))
		{ 
			SelecionarCamera(2);
		}
		
		if (Input.GetKeyDown ("3"))
		{ 
			SelecionarCamera(3);
		}
		
		if (Input.GetKeyDown ("4"))
		{ 
			SelecionarCamera(4);
		}
		
		if (Input.GetKeyDown ("5"))
		{ 
			SelecionarCamera(5);
		}
		
		if (Input.GetKeyDown ("6"))
		{ 
			SelecionarCamera(6);
		}
		
		if (Input.GetKeyDown ("7"))
		{ 
			SelecionarCamera(7);
		}
		
		if (Input.GetKeyDown ("8"))
		{ 
			SelecionarCamera(8);
		}
		
		if (Input.GetKeyDown ("9"))
		{ 
			SelecionarCamera(9);
		}
		
	}
	
	
	void SelecionarCamera(int ID)
    {
        CameraSol.enabled 		= false;
        CameraMercurio.enabled 	= false;
        CameraVenus.enabled 	= false;
        CameraTerra.enabled 	= false;
        CameraMarte.enabled 	= false;
        CameraJupiter.enabled 	= false;
        CameraSaturno.enabled 	= false;
        CameraUrano.enabled 	= false;
        CameraNetuno.enabled 	= false;
        CameraPadrao.enabled 	= false;

        switch (ID)
        {
            case 0:
                CameraSol.enabled 		= true;
                break;
            case 1:
                CameraMercurio.enabled 	= true;
                break;
            case 2:
                CameraVenus.enabled 	= true;
                break;
            case 3:
                CameraTerra.enabled 	= true;
                break;
            case 4:
                CameraMarte.enabled 	= true;
                break;
            case 5:
                CameraJupiter.enabled 	= true;
                break;
            case 6:
                CameraSaturno.enabled 	= true;
                break;
            case 7:
                CameraUrano.enabled 	= true;
                break;
            case 8:
                CameraNetuno.enabled 	= true;
                break;
            case 9:
                CameraPadrao.enabled 	= true;
                break;
        }
    }	
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

	public void PlayGame ()
    {
        Application.LoadLevel(1);
    }

	public void MainMenu ()
	{
		Application.LoadLevel(0);
	}
		
	}

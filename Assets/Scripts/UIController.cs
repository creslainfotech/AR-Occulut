using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI ;

public class UIController : MonoBehaviour 
{
	public void LoadMenuScene()
	{
		SceneManager.LoadScene ("MenuScene");
	}

	public void LoadTitleScene()
	{
		SceneManager.LoadScene ("TitileScene");
	}

	public void LoadAR()
    {
        SceneManager.LoadScene("ARcamScene");
    }
    public void Loadclue()
    {
        SceneManager.LoadScene("clue");
    }

    public void Quit()
	{
		Application.Quit ();
	}
}

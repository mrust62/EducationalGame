using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
	{
		SceneManager.LoadSceneAsync(1);
	}
	public void PlayMars()
	{
		SceneManager.LoadSceneAsync(4);
	}
	public void PlayMars1()
	{
		SceneManager.LoadSceneAsync(2);
	}
	public void PlayMars2()
	{
		SceneManager.LoadSceneAsync(5);
        BGmusic.instance.GetComponent<AudioSource>().Stop();
    }
	public void PlayMars3()
	{
		SceneManager.LoadSceneAsync(6);
	}
	public void PlayVenus()
	{
		SceneManager.LoadSceneAsync(7);
	}
	public void PlayVenus1()
	{
		SceneManager.LoadSceneAsync(10);
	}
	public void PlayEarth()
	{
		SceneManager.LoadSceneAsync(8);
	}
	public void PlayEarth1()
	{
		SceneManager.LoadSceneAsync(9);
    }

}

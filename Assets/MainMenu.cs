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
		SceneManager.LoadSceneAsync(2);
	}
	public void PlayVenus()
	{
		SceneManager.LoadSceneAsync(3);
	}
	public void PlayEarth()
	{
		SceneManager.LoadSceneAsync(4);
	}
}

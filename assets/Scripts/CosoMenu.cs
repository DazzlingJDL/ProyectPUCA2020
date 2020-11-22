using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CosoMenu : MonoBehaviour
{
	public GameObject CosoUI;
	public GameObject MenuUI;
	public GameObject SoundUI;
	public GameObject ModeUI;
	public GameObject VolSlider;
	public int gameMode = 1;
	public int soundSel = 1;
	public float sVolume;
	
	// Update is called once per frame
	void Update()
	{
		sVolume = VolSlider.GetComponent<Slider>().value;
	}
	
	public void HideAll()
	{
		CosoUI.SetActive(false);
		MenuUI.SetActive(false);
		SoundUI.SetActive(false);
		ModeUI.SetActive(false);
	}	
	
	public void Pause()
	{
		CosoUI.SetActive(false);
		MenuUI.SetActive(true);
	}
	
	public void Continue()
	{
		MenuUI.SetActive(false);
		CosoUI.SetActive(true);
	}
	
	public void Options()
	{
		MenuUI.SetActive(false);
		SoundUI.SetActive(true);
	}
	
	public void Back()
	{
		SoundUI.SetActive(false);
		MenuUI.SetActive(true);
	}
	
	public void Mode()
	{
		SoundUI.SetActive(false);
		ModeUI.SetActive(true);
	}
	
	public void BackMode()
	{
		ModeUI.SetActive(false);
		SoundUI.SetActive(true);
	}
	
	public void SDefault()
	{
		soundSel = 1;
	}
	
	public void SAruru()
	{
		soundSel = 2;
	}
	
	public void EasyMode()
	{
		gameMode = 0;
	}
	
	public void NormalMode()
	{
		gameMode = 1;
	}
	
	public void HardMode()
	{
		gameMode = 2;
	}
	
	public void Quit()
	{
		SceneManager.LoadScene("mainmenu");
	}
	
}
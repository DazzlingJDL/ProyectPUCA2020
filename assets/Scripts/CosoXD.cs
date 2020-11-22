using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CosoXD : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public GameObject backSprite;
	public GameObject button1;
	public GameObject button2;
	public GameObject sound;
	public GameObject sound1;
	public GameObject sound2;
	public int soundSel = 1;
	public int soundSelCM = 1;
	public bool buttonPressed;
	public float sVolume;
	
    // Update is called once per frame
    void Update()
    {
		soundSelCM = GameObject.Find("Canvas").GetComponent<CosoMenu>().soundSel;
		if (soundSel != soundSelCM)
		{
			soundSel = soundSelCM;
			if (soundSel == 1)
			{
				sound = sound1;
			}
			if (soundSel == 2)
			{
				sound = sound2;
			}				
		} 
		
		
		sVolume = GameObject.Find("Canvas").GetComponent<CosoMenu>().sVolume;
		sound.GetComponent<AudioSource>().volume = sVolume;

	}
       
	   
	public void button()
    {
		
    }
	
	public void OnPointerDown(PointerEventData eventData){
		buttonPressed = true;
		this.GetComponent<Image>().sprite = button2.GetComponent<SpriteRenderer>().sprite;
		sound.SetActive(false);
		sound.SetActive(true);
		backSprite.SetActive(true);
	}
 
	public void OnPointerUp(PointerEventData eventData){
		this.GetComponent<Image>().sprite = button1.GetComponent<SpriteRenderer>().sprite;
		backSprite.SetActive(false);
	}
	
}

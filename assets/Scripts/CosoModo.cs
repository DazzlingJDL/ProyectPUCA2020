using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CosoModo : MonoBehaviour
{
	public GameObject Canvas;
	public GameObject Coso;
	public GameObject CosoEasy;
	public GameObject CosoNormal;
	public GameObject CosoHard;
	public GameObject Borange;
	public GameObject Byellow;
	public GameObject Bhard;
	public int gMode;
	
	// Update is called once per frame
	void Update()
	{
		gMode = Canvas.GetComponent<CosoMenu>().gameMode;
		
		if(gMode == 0) 
		{
			Coso.GetComponent<Image>().sprite = CosoEasy.GetComponent<Image>().sprite;
			Borange.SetActive(false);
			Byellow.SetActive(false);
			Bhard.SetActive(false);
		}
		
		if(gMode == 1)
		{
			Coso.GetComponent<Image>().sprite = CosoNormal.GetComponent<Image>().sprite;
			Borange.SetActive(true);
			Byellow.SetActive(true);
			Bhard.SetActive(false);
		}
		
		if(gMode == 2)
		{
			Coso.GetComponent<Image>().sprite = CosoHard.GetComponent<Image>().sprite;
			Borange.SetActive(true);
			Byellow.SetActive(true);
			Bhard.SetActive(true);
		}
	}
	
}
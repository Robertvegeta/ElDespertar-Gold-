using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambios : MonoBehaviour {
	
	public GameObject capL;
	public GameObject capNL;
	public GameObject libro;
	public GameObject itemlibro;
	public GameObject dinero;
	public GameObject polvos;	
	public int sinlibro=0;
	public int item=0;
	
	// Use this for initialization
	void Start () {
		sinlibro = PlayerPrefs.GetInt("librofuera");
		item = PlayerPrefs.GetInt("polvos");
		if (sinlibro==1){
			capL.SetActive(false);
			capNL.SetActive(true);
			libro.SetActive(false);
			itemlibro.SetActive(true);
		}
		if (item==1){
			polvos.SetActive(true);
			dinero.SetActive(false);

		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape))
			{
			 SceneManager.LoadScene("Menu");
			}
		
	}
}

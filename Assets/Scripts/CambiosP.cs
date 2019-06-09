using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiosP : MonoBehaviour {
	

	public GameObject itemlibro;
	public int sinlibro=0;
	public int inicio=0;
	public int tendero=0;
	private Animator protagonista;
	public GameObject personaje;
	public GameObject movimiento;
	public GameObject polvos;
	public GameObject dinero;
	public GameObject tiendaC;
	public GameObject tiendaA;
	public GameObject tenderoP;
	public GameObject colliderC;
	public GameObject colliderPA;
	public GameObject colliderPC;
	public GameObject colliderT;
	public GameObject colliderP;
	public GameObject colliderMR;
	public GameObject colliderMA;
	public GameObject colliderMV;
	public GameObject colliderM;	
	
	// Use this for initialization
	void Start () {
		movimiento.SetActive(false);
		protagonista = personaje.GetComponent<Animator>();
		sinlibro = PlayerPrefs.GetInt("librofuera");
		tendero = PlayerPrefs.GetInt("polvos");
		if (sinlibro==1){

			itemlibro.SetActive(true);
		}
		if (inicio==0){
			
			protagonista.Play("Inicio");
		}
		if (tendero==1){
			
			tiendaC.SetActive(false);
			tiendaA.SetActive(true);
			tenderoP.SetActive(true);
			colliderC.SetActive(true);
			colliderPA.SetActive(true);
			colliderPC.SetActive(false);
			colliderT.SetActive(true);
			colliderP.SetActive(true);
			colliderMR.SetActive(true);
			colliderMA.SetActive(true);
			colliderMV.SetActive(true);
			colliderM.SetActive(true);
			dinero.SetActive(false);
			polvos.SetActive(true);
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

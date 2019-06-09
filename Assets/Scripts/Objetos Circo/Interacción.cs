using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Interacción : MonoBehaviour {
	
	public GameObject panel;
	private Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	public GameObject personaje;
	float number=0;	
	// Use this for initialization
	void Start () {
		descripcion = panel.GetComponent<Text>();
		protagonista = personaje.GetComponent<Animator>();
			descripcion.text = "Ups, parece que ésto está en construcción, mejor vuelvo por dónde he venido";
			//movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Espera ()
     {
        yield return new WaitForSeconds(number);
        panel.SetActive(false);
		//movimiento.SetActive(true);
		protagonista.Play("WalkI");
		SceneManager.LoadScene("Plaza");
     }	
}

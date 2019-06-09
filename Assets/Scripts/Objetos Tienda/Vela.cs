using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Vela : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	public GameObject personaje;


	int number=0;

	bool couroutineStarted= false;	

   
    // Use this for initialization
    void Start () {
        this.lastText = infoText.text;
		descripcion = panel.GetComponent<Text>();
		protagonista = personaje.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnPointerDown(PointerEventData eventData)
    {      
		Debug.Log("Object name: " + this.name);
        switch(infoText.text){
			
		  case("Mirar vela"):
		  
			descripcion.text = "Bua, esas velas dan muy buen ambiente al escenario y el efeto de luz es muy guapo. ¿A que si profesores?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir vela"):
		  
		  	descripcion.text = "No se puede abrir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar vela"):
		  
		  	descripcion.text = "No puedo cerrar una vela, si apagarla pero se vería menos de lo que ya se ve";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la vela"):
		  
		  
		   break;
		   
		  case("Hablar a la vela"):
		  
		  	descripcion.text = "Cumpleaaaaaaños feeeeeeliiiiiz, cumpleaaaaaaa. Perdón, es que me sale solo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger vela"):
		  
		  	descripcion.text = "Claro que sí, la cojo, me quemo, prendo mis pantalones....espero que hayas pillado que no lo pienso hacer";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar vela"):
		  
		  	descripcion.text = "Ya está en uso y lo cumple a la perfección";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover vela"):
		  
		  	descripcion.text = "Está pegado por la cera en el candelabro";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar vela"):
		  
		  	descripcion.text = "No quiero ofrecerselas a nadie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			//infoText.text = "caminar";			  
		  
		   break;
		  default:
		  infoText.text = objectName;
		  break;
	  } 

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("Object name: " + this.name);
	  switch(infoText.text){
		  case("Mirar"):
			infoText.text = "Mirar vela";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir vela";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar vela";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la vela";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la vela";
		   break;
		  case("Coger"):
			infoText.text = "Coger vela";
		   break;
		  case("Usar"):
			infoText.text = "Usar vela";
		   break;
		  case("Mover"):
			infoText.text = "Mover vela";
		   break;
		  case("Dar"):
			infoText.text = "Dar vela";
		   break;
		  default:
		  movimiento.SetActive(false);
		  infoText.text = objectName;
		  break;
	  } 

	}

    public void OnPointerExit(PointerEventData eventData)
    {
	  switch(infoText.text){
		  case("Mirar vela"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir vela"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar vela"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la vela"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la vela"):
			infoText.text = "Hablar";
		   break;
		  case("Coger vela"):
			infoText.text = "Coger";
		   break;
		  case("Usar vela"):
			infoText.text = "Usar";
		   break;
		  case("Mover vela"):
			infoText.text = "Mover";
		   break;
		  case("Dar vela"):
			infoText.text = "Dar";
		   break;
		  default:
			if(infoText.text == objectName){
				movimiento.SetActive(true);
			}
		  infoText.text = "caminar";
		  break;
	  } 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Hover object");
    }
	
    IEnumerator Espera ()
     {
        yield return new WaitForSeconds(number);
        panel.SetActive(false);
		movimiento.SetActive(true);
		protagonista.enabled = false;
		infoText.text = "caminar";
     }
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}


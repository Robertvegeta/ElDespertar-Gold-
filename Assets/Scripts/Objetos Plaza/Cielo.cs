using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cielo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	public GameObject personaje;


	float number=0;

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
			
		  case("Mirar cielo"):
		  
			descripcion.text = "Hoy en el sueño de Robert tendremos cielos despejados con suave viento de Poniente, con temperaturas máximas de 26º";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir cielo"):
		  
		  	descripcion.text = "Si, lo agrieto, y bajará Dios a jugar a ésto por mí";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cielo"):
		  
		  	descripcion.text = "¿Como se supone que tengo que cerrar el cielo?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el cielo"):
		  	descripcion.text = "Si, si, justo quiero eso, morirme ya e ir a presentar el trabajo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";			  
		  
		   break;
		   
		  case("Hablar al cielo"):
		  
		  	descripcion.text = "¿Jugador estás ahí? Por favor busca la manera de que salgamos de aquí por favor";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cielo"):
		  
		  	descripcion.text = "El cielo es mío, cojo un poquito de cielo por aquí, otro por allá...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cielo"):
		  
		  	descripcion.text = "¿Y como se supone que lo voy a usar?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con cielo"):
		  
		  	descripcion.text = "¿Lo tiro al aire?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover cielo"):
		  
		  	descripcion.text = "¿Que te crees que soy? ¿Atlas?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar cielo"):
		  
		  	descripcion.text = "No";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
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
			infoText.text = "Mirar cielo";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cielo";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cielo";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el cielo";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cielo";
		   break;
		  case("Coger"):
			infoText.text = "Coger cielo";
		   break;
		  case("Usar"):
			infoText.text = "Usar cielo";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con cielo";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover cielo";
		   break;
		  case("Dar"):
			infoText.text = "Dar cielo";
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
		  case("Mirar cielo"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cielo"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cielo"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el cielo"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cielo"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cielo"):
			infoText.text = "Coger";
		   break;
		  case("Usar cielo"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con cielo"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover cielo"):
			infoText.text = "Mover";
		   break;
		  case("Dar cielo"):
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
		protagonista.Play("WalkI");
		infoText.text = "caminar";
     }
	  	 
	 
	 
}

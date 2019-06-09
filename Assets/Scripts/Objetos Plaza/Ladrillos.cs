using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Ladrillos : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar ladrillos"):
		  
			descripcion.text = "Madre mía como eso siga así se va a desconchar la pared entera";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir ladrillos"):
		  
		  	descripcion.text = "¿Que quieres que tire el muro a manotazos?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar ladrillos"):
		  
		  	descripcion.text = "Para taparlo necesitaría cemento, tiempo y sobretodo GANAS";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia los ladrillos"):
		  
		  
		   break;
		   
		  case("Hablar a los ladrillos"):
		  
		  	descripcion.text = "No que luego no me dejarán en paz, que son unos tochos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger ladrillos"):
		  
		  	descripcion.text = "No tengo necesidad alguna de ir cargado con ello encima";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar ladrillos"):
		  
		  	descripcion.text = "¿y para qué iba a usar yo unos ladrillos?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con ladrillos"):
		  
		  	descripcion.text = "Mira chavales ésto ni con la corrupción del ladrillo se consigue";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover ladrillos"):
		  
		  	descripcion.text = "Me gusta vacilar de fuerza pero eso sale completamente de mis capacidades";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar ladrillos"):
		  
		  	descripcion.text = "No quiero darle un ladrillazo a nadie. A nadie que esté en mi sueño, claro";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
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
			infoText.text = "Mirar ladrillos";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir ladrillos";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar ladrillos";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia los ladrillos";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a los ladrillos";
		   break;
		  case("Coger"):
			infoText.text = "Coger ladrillos";
		   break;
		  case("Usar"):
			infoText.text = "Usar ladrillos";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con ladrillos";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover ladrillos";
		   break;
		  case("Dar"):
			infoText.text = "Dar ladrillos";
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
		  case("Mirar ladrillos"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir ladrillos"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar ladrillos"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la ladrillos"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la ladrillos"):
			infoText.text = "Hablar";
		   break;
		  case("Coger ladrillos"):
			infoText.text = "Coger";
		   break;
		  case("Usar ladrillos"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con ladrillos"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover ladrillos"):
			infoText.text = "Mover";
		   break;
		  case("Dar ladrillos"):
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

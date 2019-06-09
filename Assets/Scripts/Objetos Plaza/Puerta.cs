using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puerta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar puerta"):
		  
			descripcion.text = "Detrás de esa puerta se esconden las perversiones que mi mente desea, quizás es el mejor lugar del mundo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir puerta"):
		  
		  	descripcion.text = "Me cago en todo no se abre. ¡¿PORQUÉ NO SE ABREN LAS PUERTAS AL CIELO?!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar puerta"):
		  
		  	descripcion.text = "Ja  ja, ya están cerradas y lo sabes, no seas cabrón";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la puerta"):
		  
		  
		   break;
		   
		  case("Hablar a la puerta"):
		  
		  	descripcion.text = "¡ABRIR POR FAVOR, TENED PIEDAD DE MI! ¡QUIERO VER TODO LO QUE HAY AHÍ DENTRO!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger puerta"):
		  
		  	descripcion.text = "No puedo cogerla, es demasiado grande";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar puerta"):
		  
		  	descripcion.text = "Eso es lo que intento pero no hay manera de que pueda";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con puerta"):
		  
		  	descripcion.text = "EEEEEOOOOOOOO que tengo pasta, puedo pagarlo todo. Os puedo enterrar en dinero. ABRIIIIIDMEEEEE";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover puerta"):
		  
		  	descripcion.text = "Por más que empuje no se mueve y llamo pero no contesta nadie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar puerta"):
		  
		  	descripcion.text = "Lo que le voy a dar es una patada como no se abra de una vez";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
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
			infoText.text = "Mirar puerta";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir puerta";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar puerta";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la puerta";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la puerta";
		   break;
		  case("Coger"):
			infoText.text = "Coger puerta";
		   break;
		  case("Usar"):
			infoText.text = "Usar puerta";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con puerta";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover puerta";
		   break;
		  case("Dar"):
			infoText.text = "Dar puerta";
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
		  case("Mirar puerta"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir puerta"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar puerta"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la puerta"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la puerta"):
			infoText.text = "Hablar";
		   break;
		  case("Coger puerta"):
			infoText.text = "Coger";
		   break;
		  case("Usar puerta"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con puerta"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover puerta"):
			infoText.text = "Mover";
		   break;
		  case("Dar puerta"):
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

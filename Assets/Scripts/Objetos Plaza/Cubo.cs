using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cubo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cubo"):
		  
			descripcion.text = "Pues ya sabes, el típico que se llena de agua para llevarla de aquí para allá";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir cubo"):
		  
		  	descripcion.text = "Ya está abierto por arriba";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cubo"):
		  
		  	descripcion.text = "No tiene tapa así que poco puedo cerrarlo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el cubo"):
		  
		  
		   break;
		   
		  case("Hablar al cubo"):
		  
		  	descripcion.text = "Siento decirte que no tiene vida";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cubo"):
		  
		  	descripcion.text = "Cualquier juego Point&Click que se precie se pueden coger un cubo y una cuerda, lástima que éste no sea un juego que se precie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar cubo"):
		  
		  	descripcion.text = "¿Y llenarlo de agua de la fuente y luego derramarla en mis pantalones? No gracias";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con cubo"):
		  
		  	descripcion.text = "No pienso dejar el dinero metido ahí";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover cubo"):
		  
		  	descripcion.text = "Mejor no";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar cubo"):
		  
		  	descripcion.text = "Si está ahí tirado es que no le interesa a nadie";
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
			infoText.text = "Mirar cubo";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cubo";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cubo";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el cubo";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cubo";
		   break;
		  case("Coger"):
			infoText.text = "Coger cubo";
		   break;
		  case("Usar"):
			infoText.text = "Usar cubo";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con cubo";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover cubo";
		   break;
		  case("Dar"):
			infoText.text = "Dar cubo";
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
		  case("Mirar cubo"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cubo"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cubo"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el cubo"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cubo"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cubo"):
			infoText.text = "Coger";
		   break;
		  case("Usar cubo"):
			infoText.text = "Usar";
		   break;
		  case("Mover cubo"):
			infoText.text = "Mover";
		   break;
		  case("Dar cubo"):
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

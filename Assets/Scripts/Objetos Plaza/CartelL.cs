using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CartelL : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cartel luminoso"):
		  
			descripcion.text = "Sin duda esas luces atrayentes tienen un especial poder sobre mi";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir cartel luminoso"):
		  
		  	descripcion.text = "No se abre, a más tengo entendido que los neones están llenos de un gas super contaminante";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cartel luminoso"):
		  
		  	descripcion.text = "No se cierra";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el cartel luminoso"):
		  
		  
		   break;
		   
		  case("Hablar al cartel luminoso"):
		  
		  	descripcion.text = "Aixx que guardas con tanto ahínco dnetro de éste local guarrillo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cartel luminoso"):
		  
		  	descripcion.text = "Quedaría de lujo en casa pero creo que no podría hacerme con él";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cartel luminoso"):
		  
		  	descripcion.text = "¿Y como se supone que lo voy a usar?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con cartel luminoso"):
		  
		  	descripcion.text = "Si entrara ahí dentro cumpliría todas las delicias que se me ocurren con toda ésta pasta. ¿Habrá asiticas?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover cartel luminoso"):
		  
		  	descripcion.text = "Dejemos que siga iluminando y atrayendo a gente";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar cartel luminoso"):
		  
		  	descripcion.text = "No quiero";
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
			infoText.text = "Mirar cartel luminoso";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cartel luminoso";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cartel luminoso";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el cartel luminoso";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cartel luminoso";
		   break;
		  case("Coger"):
			infoText.text = "Coger cartel luminoso";
		   break;
		  case("Usar"):
			infoText.text = "Usar cartel luminoso";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con cartel luminoso";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover cartel luminoso";
		   break;
		  case("Dar"):
			infoText.text = "Dar cartel luminoso";
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
		  case("Mirar cartel luminoso"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cartel luminoso"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cartel luminoso"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el cartel luminoso"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cartel luminoso"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cartel luminoso"):
			infoText.text = "Coger";
		   break;
		  case("Usar cartel luminoso"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con cartel luminoso"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover cartel luminoso"):
			infoText.text = "Mover";
		   break;
		  case("Dar cartel luminoso"):
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

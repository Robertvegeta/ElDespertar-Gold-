using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Poster : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar poster"):
		  
			descripcion.text = "Quieres visitar el mejor circo de la ciudad, siga la flecha para conocer a nuestros animales y nuestros artistas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir poster"):
		  
		  	descripcion.text = "No se abre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar poster"):
		  
		  	descripcion.text = "No puedo plegarlo, perdería su funcionalidad";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el poster"):
		  
		  
		   break;
		   
		  case("Hablar al poster"):
		  
		  	descripcion.text = "¡PAYASO!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger poster"):
		  
		  	descripcion.text = "No me dan miedo los payasos pero ir con un poster de payaso encima tampoco es que me haga gracia";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar poster"):
		  
		  	descripcion.text = "Usarlo no puedo usarlo, en todo caso le hago caso y voy al circo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con poster"):
		  
		  	descripcion.text = "No se como podría usar el dinero con un poster la verdad";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover poster"):
		  
		  	descripcion.text = "No que si lo muevo la gente no sabría donde encontrar el circo y sería toda una lástima";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar poster"):
		  
		  	descripcion.text = "Mmmmmmmm, mejor no";
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
			infoText.text = "Mirar poster";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir poster";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar poster";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el poster";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al poster";
		   break;
		  case("Coger"):
			infoText.text = "Coger poster";
		   break;
		  case("Usar"):
			infoText.text = "Usar poster";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con poster";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover poster";
		   break;
		  case("Dar"):
			infoText.text = "Dar poster";
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
		  case("Mirar poster"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir poster"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar poster"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el poster"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al poster"):
			infoText.text = "Hablar";
		   break;
		  case("Coger poster"):
			infoText.text = "Coger";
		   break;
		  case("Usar poster"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con poster"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover poster"):
			infoText.text = "Mover";
		   break;
		  case("Dar poster"):
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

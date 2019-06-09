using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cortina : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	private Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	private Animator corti;
	public GameObject cortinas;	
	public GameObject personaje;
	public GameObject censored;	
	public GameObject tendero;
	private Animator tende;
	


	float number=0;

	bool couroutineStarted= false;	

   
    // Use this for initialization
    void Start () {
        this.lastText = infoText.text;
		descripcion = panel.GetComponent<Text>();
		protagonista = personaje.GetComponent<Animator>();
		corti = cortinas.GetComponent<Animator>();
		tende = tendero.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnPointerDown(PointerEventData eventData)
    {      
		Debug.Log("Object name: " + this.name);
        switch(infoText.text){
			
		  case("Mirar cortina"):
		  
			descripcion.text = "Desgraciadas cortinas, hacen que no pueda ver lo que pasa dentro del club";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir cortina"):
		  
		  	descripcion.text = "Ojalá pudiera apartarlas para poder ver pero no llego a través de las verjas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cortina"):
		  
		  	descripcion.text = "Por desgracia ya está echada";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la cortina"):
		  
		  
		   break;
		   
		  case("Hablar a la cortina"):
		  
		  	descripcion.text = "Cortinita cortinita ¿podría usted levantarse un poquitín?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cortina"):
		  
		  	descripcion.text = "No son de la algodón y yo siempre elijo lo mejor";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cortina"):
		  
		  	descripcion.text = "Si pudiera tan solo llegar a ellas creeme que lo haría. A saber cuantos manjares visuales me estoy perdiendo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con cortina"):
		  
		  	descripcion.text = "Oye, ¿hay alguien ahí? Que puedo pagaros";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;	

		  case("Usar polvos mágicos con cortina"):
		  
		  	descripcion.text = "No se yo si funcionará pero vamos a ver";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera3());
			//infoText.text = "caminar";	
			
		   break;			   
		   
		  case("Mover cortina"):
		  
		  	descripcion.text = "A ver si soplando... Nada que no hay manera";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar cortina"):
		  
		  	descripcion.text = "No quiero ofrecerselas a nadie";
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
			infoText.text = "Mirar cortina";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cortina";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cortina";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la cortina";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la cortina";
		   break;
		  case("Coger"):
			infoText.text = "Coger cortina";
		   break;
		  case("Usar"):
			infoText.text = "Usar cortina";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con cortina";
		   break;	
		  case("Usar polvos mágicos con "):
			infoText.text = "Usar polvos mágicos con cortina";
		   break;			   	   
		  case("Mover"):
			infoText.text = "Mover cortina";
		   break;
		  case("Dar"):
			infoText.text = "Dar cortina";
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
		  case("Mirar cortina"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cortina"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cortina"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la cortina"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la cortina"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cortina"):
			infoText.text = "Coger";
		   break;
		  case("Usar cortina"):
			infoText.text = "Usar";
		   break;
		  case("Mover cortina"):
			infoText.text = "Mover";
		   break;
		  case("Dar cortina"):
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
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	IEnumerator Espera3 ()
     {
        yield return new WaitForSeconds(number);
			panel.SetActive(false);
			protagonista.Play("TalkI");
			corti.enabled=true;
			StartCoroutine(Espera4());
     }	 
	 
	IEnumerator Espera4 ()
     {
        yield return new WaitForSeconds(0.34f);
			descripcion.text = "Suputamadre, yo soñando esto y en vez de estar ahí dentro estoy aquí";
			panel.SetActive(true);
			protagonista.Play("TalkI");
			censored.SetActive(true);
			number=3;
			corti.Play("CortinaMoviendose");
			tende.Play("Mirar");
			StartCoroutine(Espera5());
     }	 	 
	IEnumerator Espera5 ()
     {
        yield return new WaitForSeconds(3.3f);
        panel.SetActive(false);
		protagonista.Play("WalkI");
		tende.Play("Mirando");
		infoText.text = "caminar";
     }		 
	 
}
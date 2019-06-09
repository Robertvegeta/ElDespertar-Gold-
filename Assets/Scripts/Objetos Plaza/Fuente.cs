using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Fuente : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar fuente"):
		  
			descripcion.text = "Mira como corre el agua. Creo que mejor no diga eso en ésta fuente";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir fuente"):
		  
		  	descripcion.text = "No se puede abrir, el agua está siempre en marcha";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar fuente"):
		  
		  	descripcion.text = "No veo que tenga llave de paso a la vista";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la fuente"):
		  
		  
		   break;
		   
		  case("Hablar a la fuente"):
		  
		  	descripcion.text = "Tristemente la estatua es de piedra y no puede escucharme";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger fuente"):
		  
		  	descripcion.text = "Si, espera que ahora llamo a la grúa";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar fuente"):
		  
		  	descripcion.text = "Uy, que fresquita está el agua";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con fuente"):
		  
		  	descripcion.text = "Siempre he pensado que la gente que tira dinero a las fuentes es subnormal, pero siendo un sueño y teniendo tanto no tengo nada que perder";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera2());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover fuente"):
		  
		  	descripcion.text = "¿Como prefieres que la empuje de golpe o que la empuje piedra a piedra?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar fuente"):
		  
		  	descripcion.text = "Yo le doy a este pueblo inventado por mi mente ésta fuente fantástica";
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
			infoText.text = "Mirar fuente";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir fuente";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar fuente";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la fuente";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la fuente";
		   break;
		  case("Coger"):
			infoText.text = "Coger fuente";
		   break;
		  case("Usar"):
			infoText.text = "Usar fuente";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con fuente";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover fuente";
		   break;
		  case("Dar"):
			infoText.text = "Dar fuente";
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
		  case("Mirar fuente"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir fuente"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar fuente"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la fuente"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la fuente"):
			infoText.text = "Hablar";
		   break;
		  case("Coger fuente"):
			infoText.text = "Coger";
		   break;
		  case("Usar fuente"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con fuente"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover fuente"):
			infoText.text = "Mover";
		   break;
		  case("Dar fuente"):
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
        yield return new WaitForSeconds(number);
			descripcion.text = "Deseo que me mida 20cm";
			protagonista.Play("TalkI");
			StartCoroutine(Espera3());
     }		 
	IEnumerator Espera3 ()
     {
        yield return new WaitForSeconds(1);
			panel.SetActive(false);
			protagonista.Play("WaitI");
			StartCoroutine(Espera4());
     }
	IEnumerator Espera4 ()
     {
        yield return new WaitForSeconds(1);
			descripcion.text = "Vaya, pues si que tenía que perder. Acabo de perder una moneda";
			panel.SetActive(true);
			protagonista.Play("TalkI");
			number=3;
			StartCoroutine(Espera());
     }	 
}

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Dinero : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar dinero, mucho dinero"):
		  
			descripcion.text = "Sus muertos, que hago con tanta pasta encima, como se nota que es un sueño, no he visto tanto junto en mi vida";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir dinero, mucho dinero"):
		  
		  	descripcion.text = "El dinero no se abre. Vuela, pero no se abre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar dinero, mucho dinero"):
		  
		  	descripcion.text = "No lo llevo en un monedero para poder cerrarlo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el dinero, mucho dinero"):
		  
		  
		   break;
		   
		  case("Hablar al dinero, mucho dinero"):
		  
		  	descripcion.text = "O pequeños amigos mios, nos vamos a divertir mucho juntos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger dinero, mucho dinero"):
		  
		  	descripcion.text = "Ya es mío";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero"):
		  
		  	infoText.text = "Usar dinero, mucho dinero con ";
			
		   break;
		   
		  case("Mover dinero, mucho dinero"):
		  
		  	descripcion.text = "Dame tiempo, dame tiempo, lo moveré  en cuanto abra el club de allí";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar dinero, mucho dinero"):
		  
		  	descripcion.text = "Ni de coña le doy esto a nadie. Es mi sueño, es mi dinero y soy muuuuuy capitalista";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
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
		movimiento.SetActive(false);
       // Debug.Log("Object name: " + this.name);
	  switch(infoText.text){
		  case("Mirar"):
			infoText.text = "Mirar dinero, mucho dinero";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir dinero, mucho dinero";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar dinero, mucho dinero";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el dinero, mucho dinero";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al dinero, mucho dinero";
		   break;
		  case("Coger"):
			infoText.text = "Coger dinero, mucho dinero";
		   break;
		  case("Usar"):
			infoText.text = "Usar dinero, mucho dinero";
		   break;
		  case("Mover"):
			infoText.text = "Mover dinero, mucho dinero";
		   break;
		  case("Dar"):
			infoText.text = "Dar dinero, mucho dinero";
		   break;
		  default:
		  movimiento.SetActive(false);
		  infoText.text = objectName;
		  break;
	  } 

	}

    public void OnPointerExit(PointerEventData eventData)
    {
		movimiento.SetActive(true);
	  switch(infoText.text){
		  case("Mirar dinero, mucho dinero"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir dinero, mucho dinero"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar dinero, mucho dinero"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el dinero, mucho dinero"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al dinero, mucho dinero"):
			infoText.text = "Hablar";
		   break;
		  case("Coger dinero, mucho dinero"):
			infoText.text = "Coger";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;
		  case("Mover dinero, mucho dinero"):
			infoText.text = "Mover";
		   break;
		  case("Dar dinero, mucho dinero"):
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
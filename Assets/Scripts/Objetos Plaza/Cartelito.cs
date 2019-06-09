using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cartelito : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cartel"):
		  
			descripcion.text = "Según indica el cartel, cualquier pieza de fruta a 2 monedas. Si Timon no me la hubiera jugado...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir cartel"):
		  
		  	descripcion.text = "No se puede abrir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cartel"):
		  
		  	descripcion.text = "No puedo cerrar una cartel";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el cartel"):
		  
		  
		   break;
		   
		  case("Hablar al cartel"):
		  
		  	descripcion.text = "Cumpleaaaaaaños feeeeeeliiiiiz, cumpleaaaaaaa. Perdón, es que me sale solo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cartel"):
		  
		  	descripcion.text = "No se para que querría yo un cartel de frutas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cartel"):
		  
		  	descripcion.text = "Si comprar compraría, si el cabrón no me hubiera robado el dinero";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con cartel"):
		  
		  	descripcion.text = "Te entierro en dinero";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover cartel"):
		  
		  	descripcion.text = "Dejemos que pueda vender un poco el pobre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar cartel"):
		  
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
			infoText.text = "Mirar cartel";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cartel";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cartel";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el cartel";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cartel";
		   break;
		  case("Coger"):
			infoText.text = "Coger cartel";
		   break;
		  case("Usar"):
			infoText.text = "Usar cartel";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con cartel";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover cartel";
		   break;
		  case("Dar"):
			infoText.text = "Dar cartel";
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
		  case("Mirar cartel"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cartel"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cartel"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el cartel"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cartel"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cartel"):
			infoText.text = "Coger";
		   break;
		  case("Usar cartel"):
			infoText.text = "Usar";
		   break;
		  case("Mover cartel"):
			infoText.text = "Mover";
		   break;
		  case("Dar cartel"):
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

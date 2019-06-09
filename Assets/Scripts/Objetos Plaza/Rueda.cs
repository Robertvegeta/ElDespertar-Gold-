using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Rueda : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar rueda"):
		  
			descripcion.text = "Es una rueda de carro que se habrá roto y han tirado ahí";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir rueda"):
		  
		  	descripcion.text = "Pues ya me explicarás como puedo abrir una rueda";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar rueda"):
		  
		  	descripcion.text = "No se puede";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la rueda"):
		  
		  
		   break;
		   
		  case("Hablar a la rueda"):
		  
		  	descripcion.text = "¿Todo va sobre ruedas?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger rueda"):
		  
		  	descripcion.text = "Demasiado grande para cogerla y tampoco sabría muy bien que hacer con ella";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar rueda"):
		  
		  	descripcion.text = "Me falta el carro para poder recolocarla";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con rueda"):
		  
		  	descripcion.text = "De las dos cosas redondas yo tengo en mi bolsillo la mejor";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover rueda"):
		  
		  	descripcion.text = "No puedo está atascada entre mucha mierda";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar rueda"):
		  
		  	descripcion.text = "No puedo ofrecersela a nadie";
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
			infoText.text = "Mirar rueda";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir rueda";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar rueda";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la rueda";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la rueda";
		   break;
		  case("Coger"):
			infoText.text = "Coger rueda";
		   break;
		  case("Usar"):
			infoText.text = "Usar rueda";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con rueda";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover rueda";
		   break;
		  case("Dar"):
			infoText.text = "Dar rueda";
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
		  case("Mirar rueda"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir rueda"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar rueda"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la rueda"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la rueda"):
			infoText.text = "Hablar";
		   break;
		  case("Coger rueda"):
			infoText.text = "Coger";
		   break;
		  case("Usar rueda"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con rueda"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover rueda"):
			infoText.text = "Mover";
		   break;
		  case("Dar rueda"):
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

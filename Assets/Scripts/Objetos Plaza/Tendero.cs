using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tendero : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar tendero"):
		  
			descripcion.text = "Vaya pintas tiene, parece que está famelico";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir tendero"):
		  
		  	descripcion.text = "No, de momento no quiero matar a nadie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar tendero"):
		  
		  	descripcion.text = "No se puede";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el tendero"):
		  
		  
		   break;
		   
		  case("Hablar al tendero"):
		  
	  
		  
		   break;
		   
		  case("Coger tendero"):
		  
		  	descripcion.text = "Hombre, está chupao pero tampoco puedo cogerlo y guardarmelo en el bolsillo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar tendero"):
		  
		  	descripcion.text = "Como mucho puedo intentar hablar con él";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con tendero"):
		  
			
		   break;		   
		   
		  case("Mover tendero"):
		  
		  	descripcion.text = "No quiero empujarle, que con lo esqueletico que está me lo cargo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar tendero"):
		  
		  	descripcion.text = "Las personas no somos de nadie. NO ES NO";
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
			infoText.text = "Mirar tendero";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir tendero";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar tendero";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el tendero";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al tendero";
		   break;
		  case("Coger"):
			infoText.text = "Coger tendero";
		   break;
		  case("Usar"):
			infoText.text = "Usar tendero";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con tendero";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover tendero";
		   break;
		  case("Dar"):
			infoText.text = "Dar tendero";
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
		  case("Mirar tendero"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir tendero"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar tendero"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el tendero"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al tendero"):
			infoText.text = "Hablar";
		   break;
		  case("Coger tendero"):
			infoText.text = "Coger";
		   break;
		  case("Usar tendero"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con tendero"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover tendero"):
			infoText.text = "Mover";
		   break;
		  case("Dar tendero"):
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

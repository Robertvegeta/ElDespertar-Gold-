using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tarro2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	


	int number=0;

	bool couroutineStarted= false;	

   
    // Use this for initialization
    void Start () {
        this.lastText = infoText.text;
		descripcion = panel.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnPointerDown(PointerEventData eventData)
    {      
		Debug.Log("Object name: " + this.name);
        switch(infoText.text){
			
		  case("Mirar tarro con lagartija"):
		  
			descripcion.text = "Vaya, ha conseguido cogerla, yo nunca he sido capaz de coger una. Una vez casi la pillo y me quedé con su rabo en las manos. Y también con la cola";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir tarro con lagartija"):
		  
		  	descripcion.text = "Está muerta, ya no tiene gracia";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar tarro con lagartija"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el tarro con lagartija"):
		  
		  
		   break;
		   
		  case("Hablar al tarro con lagartija"):
		  
		  	descripcion.text = "Ey cuchi cuchi";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger tarro con lagartija"):
		  
		  	descripcion.text = "No creo que lo usara con nada, mejor dejarlo donde está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar tarro con lagartija"):
		  
		  	descripcion.text = "No lo puedo usar con nada";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover tarro con lagartija"):
		  
		  	descripcion.text = "Está encajado en la mesa, no creo que pueda moverlo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar tarro con lagartija"):
		  
		  	descripcion.text = "No me pertenece";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";			  
		  
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
			infoText.text = "Mirar tarro con lagartija";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir tarro con lagartija";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar tarro con lagartija";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el tarro con lagartija";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al tarro con lagartija";
		   break;
		  case("Coger"):
			infoText.text = "Coger tarro con lagartija";
		   break;
		  case("Usar"):
			infoText.text = "Usar tarro con lagartija";
		   break;
		  case("Mover"):
			infoText.text = "Mover tarro con lagartija";
		   break;
		  case("Dar"):
			infoText.text = "Dar tarro con lagartija";
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
		  case("Mirar tarro con lagartija"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir tarro con lagartija"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar tarro con lagartija"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el tarro con lagartija"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al tarro con lagartija"):
			infoText.text = "Hablar";
		   break;
		  case("Coger tarro con lagartija"):
			infoText.text = "Coger";
		   break;
		  case("Usar tarro con lagartija"):
			infoText.text = "Usar";
		   break;
		  case("Mover tarro con lagartija"):
			infoText.text = "Mover";
		   break;
		  case("Dar tarro con lagartija"):
			infoText.text = "Dar";
		   break;
		  default:
		  movimiento.SetActive(true);
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
     }
	 
}
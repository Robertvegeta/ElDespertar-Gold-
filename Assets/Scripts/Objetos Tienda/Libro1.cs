using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro marrón"):
		  
			descripcion.text = "El libro se titula: Como adelgazar con la dieta Mediterranea";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro marrón"):
		  
		  	descripcion.text = "Según pone, la dieta mediterranea ayuda a controlar tu colesterol. Uix que bien";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro marrón"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro marrón"):
		  
		  
		   break;
		   
		  case("Hablar al libro marrón"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro marrón"):
		  
		  	descripcion.text = "¡¿Estás insinuando que estoy gordo, cabrón?!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro marrón"):
		  
		  	descripcion.text = "Yo no necesito dieta alguna";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro marrón"):
		  
		  	descripcion.text = "¿Y ahora es cuando se abre un pasadizo secreto?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro marrón"):
		  
		  	descripcion.text = "No puedo dárselo a nadie";
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
			infoText.text = "Mirar libro marrón";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro marrón";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro marrón";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro marrón";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro marrón";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro marrón";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro marrón";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro marrón";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro marrón";
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
		  case("Mirar libro marrón"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro marrón"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro marrón"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro marrón"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro marrón"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro marrón"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro marrón"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro marrón"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro marrón"):
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
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}

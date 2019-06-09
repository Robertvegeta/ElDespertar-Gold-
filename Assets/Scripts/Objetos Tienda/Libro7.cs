using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro7 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro verde"):
		  
			descripcion.text = "El libro se titula: Harry Polter y la piedra pómez";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro verde"):
		  
		  	descripcion.text = "Madre mia, éste libro es todo un best seller, el niño que sobrevivió a unos padres veganos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro verde"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro verde"):
		  
		  
		   break;
		   
		  case("Hablar al libro verde"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro verde"):
		  
		  	descripcion.text = "No, que luego me engancho y me faltan el resto de la saga";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro verde"):
		  
		  	descripcion.text = "...y no alimentaron al niño con leche porque venía de la vaca y pobre vaca...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro verde"):
		  
		  	descripcion.text = "Mejor dejarlo en su sitio";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro verde"):
		  
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
			infoText.text = "Mirar libro verde";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro verde";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro verde";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro verde";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro verde";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro verde";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro verde";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro verde";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro verde";
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
		  case("Mirar libro verde"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro verde"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro verde"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro verde"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro verde"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro verde"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro verde"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro verde"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro verde"):
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

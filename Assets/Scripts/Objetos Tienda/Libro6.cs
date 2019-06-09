using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro6 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro marrón oscuro"):
		  
			descripcion.text = "El libro se titula: Trucos de magia con cartas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro marrón oscuro"):
		  
		  	descripcion.text = "Buf, muy mal te tienes que ver para llegar a éstos extremos. Pobre chaval";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro marrón oscuro"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro marrón oscuro"):
		  
		  
		   break;
		   
		  case("Hablar al libro marrón oscuro"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro marrón oscuro"):
		  
		  	descripcion.text = "Las chicas ya no se sorprenden si les enseñas trucos de cartas, ahora solo funciona si tienes muchos likes";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro marrón oscuro"):
		  
		  	descripcion.text = "Genial, ¿y con qué baraja?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1
			;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro marrón oscuro"):
		  
		  	descripcion.text = "Déjalo dónde está vaya a ser que luego no lo encuentre y parece que lo necesita bastante";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro marrón oscuro"):
		  
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
			infoText.text = "Mirar libro marrón oscuro";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro marrón oscuro";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro marrón oscuro";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro marrón oscuro";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro marrón oscuro";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro marrón oscuro";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro marrón oscuro";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro marrón oscuro";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro marrón oscuro";
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
		  case("Mirar libro marrón oscuro"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro marrón oscuro"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro marrón oscuro"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro marrón oscuro"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro marrón oscuro"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro marrón oscuro"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro marrón oscuro"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro marrón oscuro"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro marrón oscuro"):
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

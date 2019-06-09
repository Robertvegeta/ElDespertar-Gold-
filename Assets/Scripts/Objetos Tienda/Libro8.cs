using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro8 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro morado"):
		  
			descripcion.text = "El libro se titula: Magia oscura, beso negro y otros hechizos. Mmmm interesante...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro morado"):
		  
		  	descripcion.text = "¡Oh Dios, pero que oscuridad más aterradora!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro morado"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro morado"):
		  
		  
		   break;
		   
		  case("Hablar al libro morado"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro morado"):
		  
		  	descripcion.text = "No, mejor me quedo sin aprender hechizos de ese tipo...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro morado"):
		  
		  	descripcion.text = "Para inflar a una persona como un globo inserta los labios en.... hasta aquí";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro morado"):
		  
		  	descripcion.text = "Dejalo ahí mejor";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro morado"):
		  
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
			infoText.text = "Mirar libro morado";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro morado";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro morado";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro morado";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro morado";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro morado";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro morado";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro morado";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro morado";
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
		  case("Mirar libro morado"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro morado"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro morado"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro morado"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro morado"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro morado"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro morado"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro morado"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro morado"):
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

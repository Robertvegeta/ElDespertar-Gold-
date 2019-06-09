using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro negro"):
		  
			descripcion.text = "El libro se titula: Juego de Cromos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro negro"):
		  
		  	descripcion.text = "La guerra encarnizada por conseguir la colección completa con todos sus SSR, es todo un best seller";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro negro"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro negro"):
		  
		  
		   break;
		   
		  case("Hablar al libro negro"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro negro"):
		  
		  	descripcion.text = "Bua que va soy incapaz de seguirla, tiene muchos nombres de colecciones y cosas y es muy complicado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro negro"):
		  
		  	descripcion.text = "Me quedo con la serie, dónde, atención Spoiler, el Ruedas completa la colección entera";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro negro"):
		  
		  	descripcion.text = "Mejor lo dejo donde está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro negro"):
		  
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
			infoText.text = "Mirar libro negro";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro negro";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro negro";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro negro";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro negro";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro negro";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro negro";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro negro";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro negro";
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
		  case("Mirar libro negro"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro negro"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro negro"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro negro"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro negro"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro negro"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro negro"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro negro"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro negro"):
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

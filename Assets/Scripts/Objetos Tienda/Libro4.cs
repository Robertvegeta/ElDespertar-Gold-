using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro4 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	public GameObject capL;
	public GameObject capNL;
	public GameObject libro;	
	public GameObject item;
	public Image image;
	//public int sinlibro=0;
	


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
			
		  case("Mirar libro azul"):
		  
			descripcion.text = "El libro se titula: Libro de chistes, para romperse el ojete. Vaya, que explícito";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro azul"):
		  
		  	descripcion.text = "Se abre el telón, aparece un 1 y un 2 picando a una puerta, ¿título de la película? StáerTré. Sin comentarios";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro azul"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro azul"):
		  
		  
		   break;
		   
		  case("Hablar al libro azul"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro azul"):
		  
		  	descripcion.text = "Me lo voy a llevar por si me quiero desreir un rato";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera2());
			capL.SetActive(false);
			capNL.SetActive(true);
			item.SetActive(true);
			infoText.text = "caminar";
			PlayerPrefs.SetInt("librofuera", 1);
			
			
		   break;
		   
		  case("Usar libro azul"):
		  
		  	descripcion.text = "Para reirme no será";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro azul"):
		  
		  	descripcion.text = "No se mueve, será el peso de la comedia";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro azul"):
		  
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
			infoText.text = "Mirar libro azul";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro azul";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro azul";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro azul";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro azul";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro azul";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro azul";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro azul";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro azul";
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
		  case("Mirar libro azul"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro azul"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro azul"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro azul"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro azul"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro azul"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro azul"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro azul"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro azul"):
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
        yield return new WaitForSeconds(number);
		panel.SetActive(false);
		movimiento.SetActive(true);
		/*if(){
			
		}*/
		libro.SetActive(false);
     }
	 
}

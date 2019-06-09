using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libros : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libros polvorientos"):
		  
			descripcion.text = "Los cubre una capa de mierda más grande que mi tocha, que ya es decir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libros polvorientos"):
		  
		  	descripcion.text = "Y me entra de todo si me acerco a ellos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libros polvorientos"):
		  
		  	descripcion.text = "Ya están cerrados y me arriesgaría a decir que pegados";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia los libros polvorientos"):
		  
		  
		   break;
		   
		  case("Hablar a los libros polvorientos"):
		  
		  	descripcion.text = "Bua estais para el arrastre ¿eh?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libros polvorientos"):
		  
		  	descripcion.text = "Soy alérgico al polvo y acercarme más a ellos me mataría. Espera....si es lo que busco";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libros polvorientos"):
		  
		  	descripcion.text = "¿Usar para qué? Si los cojo y se desintegran fijo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libros polvorientos"):
		  
		  	descripcion.text = "No me acerco a ellos ni que me paguen";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libros polvorientos"):
		  
		  	descripcion.text = "No puedo dárselo a nadie ni quiero";
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
			infoText.text = "Mirar libros polvorientos";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libros polvorientos";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libros polvorientos";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia los libros polvorientos";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a los libros polvorientos";
		   break;
		  case("Coger"):
			infoText.text = "Coger libros polvorientos";
		   break;
		  case("Usar"):
			infoText.text = "Usar libros polvorientos";
		   break;
		  case("Mover"):
			infoText.text = "Mover libros polvorientos";
		   break;
		  case("Dar"):
			infoText.text = "Dar libros polvorientos";
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
		  case("Mirar libros polvorientos"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libros polvorientos"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libros polvorientos"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia los libros polvorientos"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a los libros polvorientos"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libros polvorientos"):
			infoText.text = "Coger";
		   break;
		  case("Usar libros polvorientos"):
			infoText.text = "Usar";
		   break;
		  case("Mover libros polvorientos"):
			infoText.text = "Mover";
		   break;
		  case("Dar libros polvorientos"):
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

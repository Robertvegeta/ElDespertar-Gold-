using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Atrapasueños : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar atrapasueños"):
		  
			descripcion.text = "Se puso de moda en los 90, ahora se lleva pintar mandalas, otra gilipollez";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir atrapasueños"):
		  
		  	descripcion.text = "Por mi lo destrozaría, si, pero me da que se enfadaría";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar atrapasueños"):
		  
		  	descripcion.text = "No se puede cerrar";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el atrapasueños"):
		  
		  
		   break;
		   
		  case("Hablar al atrapasueños"):
		  
		  	descripcion.text = "Ya te gustaría a ti quedarte con mis sueños...";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger atrapasueños"):
		  
		  	descripcion.text = "No haría nada con ese trasto";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar atrapasueños"):
		  
		  	descripcion.text = "En teoría eso se usa solo, lo dejas ahí y ya, supongo que será para las siestas del hechicero";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover atrapasueños"):
		  
		  	descripcion.text = "Ahí donde está, está bien";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar atrapasueños"):
		  
		  	descripcion.text = "No puedo dar algo que no es mío";
			movimiento.SetActive(false);
			panel.SetActive(true);
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
			infoText.text = "Mirar atrapasueños";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir atrapasueños";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar atrapasueños";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el atrapasueños";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al atrapasueños";
		   break;
		  case("Coger"):
			infoText.text = "Coger atrapasueños";
		   break;
		  case("Usar"):
			infoText.text = "Usar atrapasueños";
		   break;
		  case("Mover"):
			infoText.text = "Mover atrapasueños";
		   break;
		  case("Dar"):
			infoText.text = "Dar atrapasueños";
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
		  case("Mirar atrapasueños"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir atrapasueños"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar atrapasueños"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el atrapasueños"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al atrapasueños"):
			infoText.text = "Hablar";
		   break;
		  case("Coger atrapasueños"):
			infoText.text = "Coger";
		   break;
		  case("Usar atrapasueños"):
			infoText.text = "Usar";
		   break;
		  case("Mover atrapasueños"):
			infoText.text = "Mover";
		   break;
		  case("Dar atrapasueños"):
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
        yield return new WaitForSeconds(3f);
        panel.SetActive(false);
		movimiento.SetActive(true);
     }
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}

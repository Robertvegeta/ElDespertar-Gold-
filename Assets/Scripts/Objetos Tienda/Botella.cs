using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Botella : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar botella"):
		  
			descripcion.text = "En la etiqueta pone agua de la juventud pero para mi que es Vodka";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir botella"):
		  
		  	descripcion.text = "No me atrevo ni acercarme a ella";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar botella"):
		  
		  	descripcion.text = "Ya está cerrada";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la botella"):
		  
		  
		   break;
		   
		  case("Hablar a botella"):
		  
		  	descripcion.text = "Hola botella, ¿como lo llevas?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			//StartCoroutine(Espera2());
			//descripcion.text = "Madre mía, que maleducado";
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger botella"):
		  
		  	descripcion.text = "No quiero coger esa botella";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar botella"):
		  
		  	descripcion.text = "Mi madre me dijo que no comiera ni bebiera si me ofrecía gente extraña";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover botella"):
		  
		  	descripcion.text = "No. Con la suerte que tengo de ahí atrás sale una rata";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar botella"):
		  
		  	descripcion.text = "No es mía";
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
			infoText.text = "Mirar botella";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir botella";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar botella";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la botella";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a botella";
		   break;
		  case("Coger"):
			infoText.text = "Coger botella";
		   break;
		  case("Usar"):
			infoText.text = "Usar botella";
		   break;
		  case("Mover"):
			infoText.text = "Mover botella";
		   break;
		  case("Dar"):
			infoText.text = "Dar botella";
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
		  case("Mirar botella"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir botella"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar botella"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la botella"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a botella"):
			infoText.text = "Hablar";
		   break;
		  case("Coger botella"):
			infoText.text = "Coger";
		   break;
		  case("Usar botella"):
			infoText.text = "Usar";
		   break;
		  case("Mover botella"):
			infoText.text = "Mover";
		   break;
		  case("Dar botella"):
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
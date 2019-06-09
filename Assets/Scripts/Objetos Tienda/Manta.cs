using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Manta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar manta"):
		  
			descripcion.text = "Está tapando algo misterioso";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir manta"):
		  
		  	descripcion.text = "La destaparía, ¿pero y sí lo que hay debajo pierde la magia de lo misterioso?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar manta"):
		  
		  	descripcion.text = "Así tapando lo que sea que tapa ya está  bien";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la manta"):
		  
		  
		   break;
		   
		  case("Hablar a la manta"):
		  
		  	descripcion.text = "Manta, mantita, ¿qué es lo que cubres con tanto misterio?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger manta"):
		  
		  	descripcion.text = "No, me trae malos recuerdos de cuando tenía que doblar las sábanas en casa de mis padres";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar manta"):
		  
		  	descripcion.text = "No tengo frio, en los sueños la temperatura es justo la que deseas, todo un lujo.";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover manta"):
		  
		  	descripcion.text = "Venga solo un poquito va. Pues no se mueve, está acartonada, ¡que asco!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar manta"):
		  
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
			infoText.text = "Mirar manta";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir manta";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar manta";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la manta";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la manta";
		   break;
		  case("Coger"):
			infoText.text = "Coger manta";
		   break;
		  case("Usar"):
			infoText.text = "Usar manta";
		   break;
		  case("Mover"):
			infoText.text = "Mover manta";
		   break;
		  case("Dar"):
			infoText.text = "Dar manta";
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
		  case("Mirar manta"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir manta"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar manta"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la manta"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la manta"):
			infoText.text = "Hablar";
		   break;
		  case("Coger manta"):
			infoText.text = "Coger";
		   break;
		  case("Usar manta"):
			infoText.text = "Usar";
		   break;
		  case("Mover manta"):
			infoText.text = "Mover";
		   break;
		  case("Dar manta"):
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

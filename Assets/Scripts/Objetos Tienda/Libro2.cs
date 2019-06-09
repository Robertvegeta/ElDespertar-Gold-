using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro azul oscuro"):
		  
			descripcion.text = "El libro se titula: Los beneficios del Yoga";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro azul oscuro"):
		  
		  	descripcion.text = "Venga ya si ninguna persona con huesos puede hacer esto";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro azul oscuro"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro azul oscuro"):
		  
		  
		   break;
		   
		  case("Hablar al libro azul oscuro"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro azul oscuro"):
		  
		  	descripcion.text = "No me serviría de nada, soy un tronco de cuidado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro azul oscuro"):
		  
		  	descripcion.text = "Para hacer la grulla, el culto al sol, la serpiente, espera, ¿seguimos hablando del mismo libro?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro azul oscuro"):
		  
		  	descripcion.text = "¡Mierda! me acabo de cortar con el papel";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro azul oscuro"):
		  
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
			infoText.text = "Mirar libro azul oscuro";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro azul oscuro";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro azul oscuro";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro azul oscuro";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro azul oscuro";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro azul oscuro";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro azul oscuro";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro azul oscuro";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro azul oscuro";
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
		  case("Mirar libro azul oscuro"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro azul oscuro"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro azul oscuro"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro azul oscuro"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro azul oscuro"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro azul oscuro"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro azul oscuro"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro azul oscuro"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro azul oscuro"):
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

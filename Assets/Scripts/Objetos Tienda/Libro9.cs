using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro9 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro verde oscuro"):
		  
			descripcion.text = "El libro se titula: ¿Miedo a los payasos? Aprende a superarlo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro verde oscuro"):
		  
		  	descripcion.text = "¿Pero como vas a superar el miedo si ésto está lleno de fotos de payasos?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro verde oscuro"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro verde oscuro"):
		  
		  
		   break;
		   
		  case("Hablar al libro verde oscuro"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro verde oscuro"):
		  
		  	descripcion.text = "No me va a servir de nada a mi lo que me da miedo son las mujeres divorciadas que quieren recuperar la juventud con 50 años, eso si da miedo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro verde oscuro"):
		  
		  	descripcion.text = "Con lo tocho que es serviría para matar a una ballena";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro verde oscuro"):
		  
		  	descripcion.text = "Con lo que pesa no se mueve ni un centímetro";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro verde oscuro"):
		  
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
			infoText.text = "Mirar libro verde oscuro";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro verde oscuro";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro verde oscuro";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro verde oscuro";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro verde oscuro";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro verde oscuro";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro verde oscuro";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro verde oscuro";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro verde oscuro";
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
		  case("Mirar libro verde oscuro"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro verde oscuro"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro verde oscuro"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro verde oscuro"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro verde oscuro"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro verde oscuro"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro verde oscuro"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro verde oscuro"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro verde oscuro"):
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
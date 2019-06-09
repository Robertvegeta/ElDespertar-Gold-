using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mesa : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar mesa"):
		  
			descripcion.text = "El mantel que la cubre te indica que se trata de un mantel perteneciente a un hechicero, sin duda alguna";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir mesa"):
		  
		  	descripcion.text = "Creo que no es de esas plegables o extensibles";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar mesa"):
		  
		  	descripcion.text = "No creo que esté abierta";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la mesa"):
		  
		  
		   break;
		   
		  case("Hablar a la mesa"):
		  
		  	descripcion.text = "Por muy mágico que parezca el mantel no creo que se trate de una mesa parlante. Porque no lo eres, ¿verdad?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger mesa"):
		  
		  	descripcion.text = "No me cabe en los bolsillos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar mesa"):
		  
		  	descripcion.text = "Solo hay una silla y la ocupa el mago. O es muy pobre para comprar sillas o le importa bien poco el bienestar de los clientes";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover mesa"):
		  
		  	descripcion.text = "Mis riñones me acaban de pedir que te diga que no";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar mesa"):
		  
		  	descripcion.text = "No es mía";
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
			infoText.text = "Mirar mesa";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir mesa";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar mesa";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la mesa";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la mesa";
		   break;
		  case("Coger"):
			infoText.text = "Coger mesa";
		   break;
		  case("Usar"):
			infoText.text = "Usar mesa";
		   break;
		  case("Mover"):
			infoText.text = "Mover mesa";
		   break;
		  case("Dar"):
			infoText.text = "Dar mesa";
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
		  case("Mirar mesa"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir mesa"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar mesa"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la mesa"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la mesa"):
			infoText.text = "Hablar";
		   break;
		  case("Coger mesa"):
			infoText.text = "Coger";
		   break;
		  case("Usar mesa"):
			infoText.text = "Usar";
		   break;
		  case("Mover mesa"):
			infoText.text = "Mover";
		   break;
		  case("Dar mesa"):
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

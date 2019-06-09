using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Escalera : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar escalera"):
		  
			descripcion.text = "Sirve para subir y bajar, vamos lo que hace una escalera mismamente";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir escalera"):
		  
		  	descripcion.text = "Ya está abierta";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar escalera"):
		  
		  	descripcion.text = "La tendrá así por algo, mejor dejarla";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la escalera"):
		  
		  
		   break;
		   
		  case("Hablar a la escalera"):
		  
		  	descripcion.text = "No tengo nada que hablar con una escalera";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger escalera"):
		  
		  	descripcion.text = "Serían utiles pero no quiero ir cargado con ellas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar escalera"):
		  
		  	descripcion.text = "¿Y dónde me subo?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover escalera"):
		  
		  	descripcion.text = "La tendrá ahí por algún motivo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar escalera"):
		  
		  	descripcion.text = "No puedo dar algo que no es mío";
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
			infoText.text = "Mirar escalera";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir escalera";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar escalera";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la escalera";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la escalera";
		   break;
		  case("Coger"):
			infoText.text = "Coger escalera";
		   break;
		  case("Usar"):
			infoText.text = "Usar escalera";
		   break;
		  case("Mover"):
			infoText.text = "Mover escalera";
		   break;
		  case("Dar"):
			infoText.text = "Dar escalera";
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
		  case("Mirar escalera"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir escalera"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar escalera"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la escalera"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la escalera"):
			infoText.text = "Hablar";
		   break;
		  case("Coger escalera"):
			infoText.text = "Coger";
		   break;
		  case("Usar escalera"):
			infoText.text = "Usar";
		   break;
		  case("Mover escalera"):
			infoText.text = "Mover";
		   break;
		  case("Dar escalera"):
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

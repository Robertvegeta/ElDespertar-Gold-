using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cartele: MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cartel"):
		  
			descripcion.text = "Timon the sorcerer, lecturas de futuro por tan solo 10 monedas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir cartel"):
		  
		  	descripcion.text = "No se abre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cartel"):
		  
		  	descripcion.text = "Como mucho plegarlo y si lo hiciera el pobre mago se quedaría sin clientes";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la cartel"):
		  
		  
		   break;
		   
		  case("Hablar al cartel"):
		  
		  	descripcion.text = "En todo caso al tal Timon, ¿no?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			//StartCoroutine(Espera2());
			//descripcion.text = "Madre mía, que maleducado";
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cartel"):
		  
		  	descripcion.text = "Mejor dejemos que se gane el pan";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cartel"):
		  
		  	descripcion.text = "No se si consigue muchos clientes o no pero la plaza estaba desierta";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover cartel"):
		  
		  	descripcion.text = "Mejor lo dejo ahí donde está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar cartel"):
		  
		  	descripcion.text = "No es mi cartel y tampoco lo quiero";
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
			infoText.text = "Mirar cartel";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cartel";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cartel";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la cartel";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cartel";
		   break;
		  case("Coger"):
			infoText.text = "Coger cartel";
		   break;
		  case("Usar"):
			infoText.text = "Usar cartel";
		   break;
		  case("Mover"):
			infoText.text = "Mover cartel";
		   break;
		  case("Dar"):
			infoText.text = "Dar cartel";
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
		  case("Mirar cartel"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cartel"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cartel"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la cartel"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cartel"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cartel"):
			infoText.text = "Coger";
		   break;
		  case("Usar cartel"):
			infoText.text = "Usar";
		   break;
		  case("Mover cartel"):
			infoText.text = "Mover";
		   break;
		  case("Dar cartel"):
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

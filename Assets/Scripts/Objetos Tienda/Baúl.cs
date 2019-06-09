using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Baúl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar baúl"):
		  
			descripcion.text = "Supongo que tendrá conejos, sierras, sombreros de copa y todas esas cosas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir baúl"):
		  
		  	descripcion.text = "No se abre, necesita una llave";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar baúl"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el baúl"):
		  
		  
		   break;
		   
		  case("Hablar al baúl"):
		  
		  	descripcion.text = "Esto... hola";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger baúl"):
		  
		  	descripcion.text = "Sufro de dolores de espalda, mejor lo dejamos estar";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar baúl"):
		  
		  	descripcion.text = "Podría guardar algo si tuviera la llave";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover baúl"):
		  
		  	descripcion.text = "Pesa un cojón";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar baúl"):
		  
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
			infoText.text = "Mirar baúl";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir baúl";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar baúl";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el baúl";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al baúl";
		   break;
		  case("Coger"):
			infoText.text = "Coger baúl";
		   break;
		  case("Usar"):
			infoText.text = "Usar baúl";
		   break;
		  case("Mover"):
			infoText.text = "Mover baúl";
		   break;
		  case("Dar"):
			infoText.text = "Dar baúl";
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
		  case("Mirar baúl"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir baúl"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar baúl"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el baúl"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al baúl"):
			infoText.text = "Hablar";
		   break;
		  case("Coger baúl"):
			infoText.text = "Coger";
		   break;
		  case("Usar baúl"):
			infoText.text = "Usar";
		   break;
		  case("Mover baúl"):
			infoText.text = "Mover";
		   break;
		  case("Dar baúl"):
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

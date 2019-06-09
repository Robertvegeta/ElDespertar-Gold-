using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cortinas : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cortinas"):
		  
			descripcion.text = "Madre mía pensaba que no iba a volver a ver una de estas después de que pasara la época del mal gusto";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir cortinas"):
		  
		  	descripcion.text = "No se abren tienen una función... no se que función tienen";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cortinas"):
		  
		  	descripcion.text = "Ya están echadas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia las cortinas"):
		  
		  
		   break;
		   
		  case("Hablar a las cortinas"):
		  
		  	descripcion.text = "Cuanto tiempo sin veros, ¿la última vez fue en el camping, no? Allí por 1989";
			movimiento.SetActive(false);
			panel.SetActive(true);
			//StartCoroutine(Espera2());
			//descripcion.text = "Madre mía, que maleducado";
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cortinas"):
		  
		  	descripcion.text = "NI DE BROMA";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cortinas"):
		  
		  	descripcion.text = "Solo las usaría para hacer sangrar los ojos a algún vecino no deseado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover cortinas"):
		  
		  	descripcion.text = "Mejor dejalas ahí quietecitas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar cortinas"):
		  
		  	descripcion.text = "Eso eso que se las quede él";
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
			infoText.text = "Mirar cortinas";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cortinas";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cortinas";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia las cortinas";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a las cortinas";
		   break;
		  case("Coger"):
			infoText.text = "Coger cortinas";
		   break;
		  case("Usar"):
			infoText.text = "Usar cortinas";
		   break;
		  case("Mover"):
			infoText.text = "Mover cortinas";
		   break;
		  case("Dar"):
			infoText.text = "Dar cortinas";
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
		  case("Mirar cortinas"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cortinas"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cortinas"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia las cortinas"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a las cortinas"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cortinas"):
			infoText.text = "Coger";
		   break;
		  case("Usar cortinas"):
			infoText.text = "Usar";
		   break;
		  case("Mover cortinas"):
			infoText.text = "Mover";
		   break;
		  case("Dar cortinas"):
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
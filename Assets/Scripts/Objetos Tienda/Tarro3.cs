using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tarro3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar bote con sustancia viscosa"):
		  
			descripcion.text = "Creo que lo que hay dentro se mueve. Prefiero no saber lo que es";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir bote con sustancia viscosa"):
		  
		  	descripcion.text = "No quiero dejar libre a Flubber";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar bote con sustancia viscosa"):
		  
		  	descripcion.text = "Ya está cerrado y espero que herméticamente";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el bote con sustancia viscosa"):
		  
		  
		   break;
		   
		  case("Hablar al bote con sustancia viscosa"):
		  
		  	descripcion.text = "Te vi en la película, soy un gran fan tuyo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger bote con sustancia viscosa"):
		  
		  	descripcion.text = "Mejor se lo dejo al hechicero para que haga con el lo que quiera";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar bote con sustancia viscosa"):
		  
		  	descripcion.text = "No que a saber donde terminaría";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover bote con sustancia viscosa"):
		  
		  	descripcion.text = "Mejor lo dejo quietecito encima de la mesa";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar bote con sustancia viscosa"):
		  
		  	descripcion.text = "No  es mío así que no puedo dárselo a nadie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
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
			infoText.text = "Mirar bote con sustancia viscosa";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir bote con sustancia viscosa";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar bote con sustancia viscosa";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el bote con sustancia viscosa";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al bote con sustancia viscosa";
		   break;
		  case("Coger"):
			infoText.text = "Coger bote con sustancia viscosa";
		   break;
		  case("Usar"):
			infoText.text = "Usar bote con sustancia viscosa";
		   break;
		  case("Mover"):
			infoText.text = "Mover bote con sustancia viscosa";
		   break;
		  case("Dar"):
			infoText.text = "Dar bote con sustancia viscosa";
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
		  case("Mirar bote con sustancia viscosa"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir bote con sustancia viscosa"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar bote con sustancia viscosa"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el bote con sustancia viscosa"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al bote con sustancia viscosa"):
			infoText.text = "Hablar";
		   break;
		  case("Coger bote con sustancia viscosa"):
			infoText.text = "Coger";
		   break;
		  case("Usar bote con sustancia viscosa"):
			infoText.text = "Usar";
		   break;
		  case("Mover bote con sustancia viscosa"):
			infoText.text = "Mover";
		   break;
		  case("Dar bote con sustancia viscosa"):
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
	 
}

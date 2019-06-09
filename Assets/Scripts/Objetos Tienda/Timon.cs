using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Timon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	public GameObject cover;
	public GameObject delimitador;
	


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
			
		  case("Mirar a Timon"):
		  
			descripcion.text = "Éste hechicero me suena de algo....pero menudas pintas lleva";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir a Timon"):
		  
		  	descripcion.text = "No me gusta ser Jack el destripador en mi tiempo libre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar a Timon"):
		  
		  	descripcion.text = "Ya está cerrado con su carne, su pelo y sus huesos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia Timon"):
		  
		  
		   break;
		   
		  case("Hablar a Timon"):
		  
			movimiento.SetActive(false);
			cover.SetActive(true);
			delimitador.SetActive(false);			
		  
		   break;
		   
		  case("Coger a Timon"):
		  
		  	descripcion.text = "Ya le gustaría a él, piratilla";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar a Timon"):
		  
		  	descripcion.text = "Mejor hablo y ya está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover a Timon"):
		  
		  	descripcion.text = "Creo que si le empujo de la silla se molestará, aunque debo aceptar que verle caer sería gracioso";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar a Timon"):
		  
		  	descripcion.text = "¿El qué precisamente?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
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
			infoText.text = "Mirar a Timon";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir a Timon";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar a Timon";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia Timon";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a Timon";
		   break;
		  case("Coger"):
			infoText.text = "Coger a Timon";
		   break;
		  case("Usar"):
			infoText.text = "Usar a Timon";
		   break;
		  case("Mover"):
			infoText.text = "Mover a Timon";
		   break;
		  case("Dar"):
			infoText.text = "Dar a Timon";
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
		  case("Mirar a Timon"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir a Timon"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar a Timon"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia Timon"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a Timon"):
			infoText.text = "Hablar";
		   break;
		  case("Coger a Timon"):
			infoText.text = "Coger";
		   break;
		  case("Usar a Timon"):
			infoText.text = "Usar";
		   break;
		  case("Mover a Timon"):
			infoText.text = "Mover";
		   break;
		  case("Dar a Timon"):
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
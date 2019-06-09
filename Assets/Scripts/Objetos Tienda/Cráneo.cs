using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cráneo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar cráneo"):
		  
			descripcion.text = "Espero por Dios que eso sea de atrezzo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir cráneo"):
		  
		  	descripcion.text = "Mejor dejemos que descanse en paz";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar cráneo"):
		  
		  	descripcion.text = "Más cerrado que está, imposible";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el cráneo"):
		  
		  
		   break;
		   
		  case("Hablar al cráneo"):
		  
		  	descripcion.text = "Ey Murray";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger cráneo"):
		  
		  	descripcion.text = "No pongo las manos encima ni muerto, jeje";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar cráneo"):
		  
		  	descripcion.text = "Me quedo con el mio, ya me está bien";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover cráneo"):
		  
		  	descripcion.text = "No, que esas cosas siempre están llenas de gusanos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar cráneo"):
		  
		  	descripcion.text = "Quita, quita";
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
			infoText.text = "Mirar cráneo";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir cráneo";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar cráneo";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el cráneo";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al cráneo";
		   break;
		  case("Coger"):
			infoText.text = "Coger cráneo";
		   break;
		  case("Usar"):
			infoText.text = "Usar cráneo";
		   break;
		  case("Mover"):
			infoText.text = "Mover cráneo";
		   break;
		  case("Dar"):
			infoText.text = "Dar cráneo";
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
		  case("Mirar cráneo"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir cráneo"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar cráneo"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el cráneo"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al cráneo"):
			infoText.text = "Hablar";
		   break;
		  case("Coger cráneo"):
			infoText.text = "Coger";
		   break;
		  case("Usar cráneo"):
			infoText.text = "Usar";
		   break;
		  case("Mover cráneo"):
			infoText.text = "Mover";
		   break;
		  case("Dar cráneo"):
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

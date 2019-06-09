using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tapete : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar tapete"):
		  
			descripcion.text = "Si el resto de la tienda es cutre, ésto ya se lleva la palma, es feo a más no poder, típico de casa de abuela";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=6;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir tapete"):
		  
		  	descripcion.text = "No se puede abrir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar tapete"):
		  
		  	descripcion.text = "No se puede cerrar";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el tapete"):
		  
		  
		   break;
		   
		  case("Hablar al tapete"):
		  
		  	descripcion.text = "Alto, policía del buen gusto, ¡queda usted arrestado!";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger tapete"):
		  
		  	descripcion.text = "Estoooooooo No";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar tapete"):
		  
		  	descripcion.text = "Eso solo puede usarse para destruirlo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover tapete"):
		  
		  	descripcion.text = "Lo quitaría pero no es mío vaya ser que se enfade";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar tapete"):
		  
		  	descripcion.text = "No lo tengo, ni ganas";
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
			infoText.text = "Mirar tapete";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir tapete";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar tapete";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el tapete";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al tapete";
		   break;
		  case("Coger"):
			infoText.text = "Coger tapete";
		   break;
		  case("Usar"):
			infoText.text = "Usar tapete";
		   break;
		  case("Mover"):
			infoText.text = "Mover tapete";
		   break;
		  case("Dar"):
			infoText.text = "Dar tapete";
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
		  case("Mirar tapete"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir tapete"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar tapete"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el tapete"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al tapete"):
			infoText.text = "Hablar";
		   break;
		  case("Coger tapete"):
			infoText.text = "Coger";
		   break;
		  case("Usar tapete"):
			infoText.text = "Usar";
		   break;
		  case("Mover tapete"):
			infoText.text = "Mover";
		   break;
		  case("Dar tapete"):
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

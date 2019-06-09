using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Plaza : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar plaza"):
		  
			descripcion.text = "Por allí se sale de la tienda y se vuelve a la plaza principal";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir plaza"):
		  

			
		   break;
		   
		  case("Cerrar plaza"):
		  

			
		   break;
		   
		  case("Caminar hacia la plaza"):
		  
			SceneManager.LoadScene("Plaza");
			
		   break;
		   
		  case("Hablar a la plaza"):
		  
	  
		  
		   break;
		   
		  case("Coger plaza"):
		  

			
		   break;
		   
		  case("Usar plaza"):
		  

			
		   break;
		   
		  case("Mover plaza"):
		  

			
		   break;
		  case("Dar plaza"):
		  
		  
		  
		   break;
		  default:
		  SceneManager.LoadScene("Plaza");
		  break;
	  } 

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("Object name: " + this.name);
	  switch(infoText.text){
		  case("Mirar"):
			infoText.text = "Mirar plaza";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir plaza";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar plaza";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la plaza";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la plaza";
		   break;
		  case("Coger"):
			infoText.text = "Coger plaza";
		   break;
		  case("Usar"):
			infoText.text = "Usar plaza";
		   break;
		  case("Mover"):
			infoText.text = "Mover plaza";
		   break;
		  case("Dar"):
			infoText.text = "Dar plaza";
		   break;
		  default:
		  infoText.text = objectName;
		  break;
	  } 

	}

    public void OnPointerExit(PointerEventData eventData)
    {
	  switch(infoText.text){
		  case("Mirar plaza"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir plaza"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar plaza"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la plaza"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la plaza"):
			infoText.text = "Hablar";
		   break;
		  case("Coger plaza"):
			infoText.text = "Coger";
		   break;
		  case("Usar plaza"):
			infoText.text = "Usar";
		   break;
		  case("Mover plaza"):
			infoText.text = "Mover";
		   break;
		  case("Dar plaza"):
			infoText.text = "Dar";
		   break;
		  default:
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

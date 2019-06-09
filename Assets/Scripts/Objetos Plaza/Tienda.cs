using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Tienda : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar tienda misteriosa"):
		  
			descripcion.text = "¿Que pinta una carpa aquí?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir tienda misteriosa"):
		  
			descripcion.text = "Ya está abierta";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar tienda misteriosa"):
		  
			descripcion.text = "No, que si está abierta será por algo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Caminar hacia la tienda misteriosa"):
		  
			SceneManager.LoadScene("Tienda");
			
		   break;
		   
		  case("Hablar a la tienda misteriosa"):
		  
	  
		  
		   break;
		   
		  case("Coger tienda misteriosa"):
		  

			
		   break;
		   
		  case("Usar tienda misteriosa"):
		  

			
		   break;
		   
		  case("Mover tienda misteriosa"):
		  

			
		   break;
		  case("Dar tienda misteriosa"):
		  
		  
		  
		   break;
		  
		  case("Tienda misteriosa"):
		  
			SceneManager.LoadScene("Tienda");
			
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
			infoText.text = "Mirar tienda misteriosa";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir tienda misteriosa";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar tienda misteriosa";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la tienda misteriosa";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la tienda misteriosa";
		   break;
		  case("Coger"):
			infoText.text = "Coger tienda misteriosa";
		   break;
		  case("Usar"):
			infoText.text = "Usar tienda misteriosa";
		   break;
		  case("Mover"):
			infoText.text = "Mover tienda misteriosa";
		   break;
		  case("Dar"):
			infoText.text = "Dar tienda misteriosa";
		   break;
		  default:
		  infoText.text = objectName;
		  break;
	  } 

	}

    public void OnPointerExit(PointerEventData eventData)
    {
	  switch(infoText.text){
		  case("Mirar tienda misteriosa"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir tienda misteriosa"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar tienda misteriosa"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la tienda misteriosa"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la tienda misteriosa"):
			infoText.text = "Hablar";
		   break;
		  case("Coger tienda misteriosa"):
			infoText.text = "Coger";
		   break;
		  case("Usar tienda misteriosa"):
			infoText.text = "Usar";
		   break;
		  case("Mover tienda misteriosa"):
			infoText.text = "Mover";
		   break;
		  case("Dar tienda misteriosa"):
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

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Circo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	public GameObject personaje;	


	int number=0;

	bool couroutineStarted= false;	

   
    // Use this for initialization
    void Start () {
        this.lastText = infoText.text;
		descripcion = panel.GetComponent<Text>();
		protagonista = personaje.GetComponent<Animator>();		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnPointerDown(PointerEventData eventData)
    {      
		Debug.Log("Object name: " + this.name);
        switch(infoText.text){
			
		  case("Mirar camino que va al circo"):
		  
			descripcion.text = "Es bastante lúgubre";
			movimiento.SetActive(false);
			panel.SetActive(true);
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir camino que va al circo"):

			
		   break;
		   
		  case("Cerrar camino que va al circo"):
		  

			
		   break;
		   
		  case("Caminar hacia el camino que va al circo"):
		  
			SceneManager.LoadScene("Circo");
			
		   break;
		   
		  case("Hablar al camino que va al circo"):
		  
	  
		  
		   break;
		   
		  case("Coger camino que va al circo"):
		  

			
		   break;
		   
		  case("Usar camino que va al circo"):
		  

			
		   break;
		   
		  case("Mover camino que va al circo"):
		  

			
		   break;
		  case("Dar camino que va al circo"):
		  
		  
		  
		   break;
		  
		  case("Camino que va al circo"):
		  
			SceneManager.LoadScene("Circo");
			
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
			infoText.text = "Mirar camino que va al circo";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir camino que va al circo";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar camino que va al circo";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el camino que va al circo";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al camino que va al circo";
		   break;
		  case("Coger"):
			infoText.text = "Coger camino que va al circo";
		   break;
		  case("Usar"):
			infoText.text = "Usar camino que va al circo";
		   break;
		  case("Mover"):
			infoText.text = "Mover camino que va al circo";
		   break;
		  case("Dar"):
			infoText.text = "Dar camino que va al circo";
		   break;
		  default:
		  infoText.text = objectName;
		  break;
	  } 

	}

    public void OnPointerExit(PointerEventData eventData)
    {
	  switch(infoText.text){
		  case("Mirar camino que va al circo"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir camino que va al circo"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar camino que va al circo"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el camino que va al circo"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al camino que va al circo"):
			infoText.text = "Hablar";
		   break;
		  case("Coger camino que va al circo"):
			infoText.text = "Coger";
		   break;
		  case("Usar camino que va al circo"):
			infoText.text = "Usar";
		   break;
		  case("Mover camino que va al circo"):
			infoText.text = "Mover";
		   break;
		  case("Dar camino que va al circo"):
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
		protagonista.Play("WalkI");		
		movimiento.SetActive(true);
		infoText.text = "caminar";		
     }
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}

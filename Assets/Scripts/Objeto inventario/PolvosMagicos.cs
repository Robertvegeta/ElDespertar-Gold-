using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PolvosMagicos : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;
	public GameObject panel;
	public Text descripcion;
    private string lastText;
	public GameObject movimiento;
	private Animator protagonista;
	public GameObject personaje;


	float number=0;

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
			
		  case("Mirar polvos mágicos"):
		  
			descripcion.text = "Pues parecen unos polvos cualquiera, eso sí, en lila y brilli brilli molón";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir polvos mágicos"):
		  
		  	descripcion.text = "Pues la verdad no se si se pueden abrir pero no lo creo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar polvos mágicos"):
		  
		  	descripcion.text = "No se pueden cerrar los polvos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia los polvos mágicos"):
		  
		  
		   break;
		   
		  case("Hablar a los polvos mágicos"):
		  
		  	descripcion.text = "¿Y que narices puedo hacer con vosotros?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger polvos mágicos"):
		  
		  	descripcion.text = "Ya son míos, y no se los pienso dar a nadie que me han costado demasiado dinero. Maldito mago de pacotilla";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar polvos mágicos"):
			movimiento.SetActive(false);
			infoText.text = "Usar polvos mágicos con ";	
			
		   break;
		   	   
		   
		  case("Mover polvos mágicos"):
		  
		  	descripcion.text = "No tienen consistencia para que los mueva, como mucho los tiro al suelo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar polvos mágicos"):
		  
		  	descripcion.text = "Ésto me lo quedo yo que me han costado un quintal de la cara";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
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
			infoText.text = "Mirar polvos mágicos";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir polvos mágicos";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar polvos mágicos";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia los polvos mágicos";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a los polvos mágicos";
		   break;
		  case("Coger"):
			infoText.text = "Coger polvos mágicos";
		   break;
		  case("Usar"):
			infoText.text = "Usar polvos mágicos";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con polvos mágicos";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover polvos mágicos";
		   break;
		  case("Dar"):
			infoText.text = "Dar polvos mágicos";
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
		  case("Mirar polvos mágicos"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir polvos mágicos"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar polvos mágicos"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia los polvos mágicos"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a los polvos mágicos"):
			infoText.text = "Hablar";
		   break;
		  case("Coger polvos mágicos"):
			infoText.text = "Coger";
		   break;
		  case("Usar polvos mágicos"):
			infoText.text = "Usar";
		   break;
		  case("Usar polvos mágicos con "):
			infoText.text = "Usar polvos mágicos con ";
		   break;		   
		  case("Mover polvos mágicos"):
			infoText.text = "Mover";
		   break;
		  case("Dar polvos mágicos"):
			infoText.text = "Dar";
		   break;
		  default:
			if(infoText.text == objectName){
				movimiento.SetActive(true);
			}
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
		protagonista.Play("WalkI");
		infoText.text = "caminar";
     }

}

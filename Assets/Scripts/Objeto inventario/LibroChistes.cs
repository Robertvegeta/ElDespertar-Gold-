using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LibroChistes : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro de chistes"):
		  
			descripcion.text = "Vale está claro que éstas vallas están protegiendo algo muy importante. Ahora tengo más ganas de traspasarlas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro de chistes"):
		  
		  	descripcion.text = "No se doblan por más que lo intento";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro de chistes"):
		  
		  	descripcion.text = "No se puede";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro de chistes"):
		  
		  
		   break;
		   
		  case("Hablar al libro de chistes"):
		  
		  	descripcion.text = "¿Que estáis ocultando pinchitos bonitos?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro de chistes"):
		  
		  	descripcion.text = "Es demasiado grande y está demasiado bien cogida al suelo como para hacerme con ella";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar libro de chistes"):
		  
		  	descripcion.text = "Como mucho intentar saltarla pero con esos pinchos arriba, ni de coña";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con libro de chistes"):
		  
		  	descripcion.text = "Lo único que conseguiría es quedarme sin él y eso no lo voy a consentir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover libro de chistes"):
		  
		  	descripcion.text = "Que va, no hay manera. Está bien anclada al suelo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro de chistes"):
		  
		  	descripcion.text = "No puedo ofrecersela a nadie";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
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
			infoText.text = "Mirar libro de chistes";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro de chistes";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro de chistes";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro de chistes";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro de chistes";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro de chistes";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro de chistes";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con libro de chistes";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover libro de chistes";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro de chistes";
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
		  case("Mirar libro de chistes"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro de chistes"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro de chistes"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro de chistes"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro de chistes"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro de chistes"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro de chistes"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con libro de chistes"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover libro de chistes"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro de chistes"):
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

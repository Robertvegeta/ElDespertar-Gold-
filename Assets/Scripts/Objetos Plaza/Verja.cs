using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Verja : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar verja"):
		  
			descripcion.text = "Vale está claro que éstas vallas están protegiendo algo muy importante. Ahora tengo más ganas de traspasarlas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir verja"):
		  
		  	descripcion.text = "No se doblan por más que lo intento";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar verja"):
		  
		  	descripcion.text = "No se puede";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la verja"):
		  
		  
		   break;
		   
		  case("Hablar a la verja"):
		  
		  	descripcion.text = "¿Que estáis ocultando pinchitos bonitos?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger verja"):
		  
		  	descripcion.text = "Es demasiado grande y está demasiado bien cogida al suelo como para hacerme con ella";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar verja"):
		  
		  	descripcion.text = "Como mucho intentar saltarla pero con esos pinchos arriba, ni de coña";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con verja"):
		  
		  	descripcion.text = "Lo único que conseguiría es quedarme sin él y eso no lo voy a consentir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover verja"):
		  
		  	descripcion.text = "Que va, no hay manera. Está bien anclada al suelo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar verja"):
		  
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
			infoText.text = "Mirar verja";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir verja";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar verja";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la verja";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la verja";
		   break;
		  case("Coger"):
			infoText.text = "Coger verja";
		   break;
		  case("Usar"):
			infoText.text = "Usar verja";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con verja";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover verja";
		   break;
		  case("Dar"):
			infoText.text = "Dar verja";
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
		  case("Mirar verja"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir verja"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar verja"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la verja"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la verja"):
			infoText.text = "Hablar";
		   break;
		  case("Coger verja"):
			infoText.text = "Coger";
		   break;
		  case("Usar verja"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con verja"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover verja"):
			infoText.text = "Mover";
		   break;
		  case("Dar verja"):
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

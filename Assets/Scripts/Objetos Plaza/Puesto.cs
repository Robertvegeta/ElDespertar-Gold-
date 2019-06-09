using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puesto : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar puesto vacío"):
		  
			descripcion.text = "Parece el típico puesto de mercadillo de pueblo pero está desierto";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir puesto vacío"):
		  
		  	descripcion.text = "No tiene nada que se pueda abrir";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar puesto vacío"):
		  
		  	descripcion.text = "No lo voy a desmontar que con mi suerta aparece el tendero y me pilla";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el puesto vacío"):
		  
		  
		   break;
		   
		  case("Hablar al puesto vacío"):
		  
		  	descripcion.text = "Hola señor invisible ¿me puede poner 3kg de nada?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger puesto vacío"):
		  
		  	descripcion.text = "Eso no tiene demasiado sentido";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar puesto vacío"):
		  
		  	descripcion.text = "Ya estoy forrado de pasta imaginaria, solo faltaría que también trabajara en sueños";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con puesto vacío"):
		  
		  	descripcion.text = "Si tuviera un tendero y género pues aún, pero sin nadie no tiene sentido alguno";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			protagonista.Play("TalkI");
			protagonista.enabled=true;			
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;		   
		   
		  case("Mover puesto vacío"):
		  
		  	descripcion.text = "Nah, mejor dejarlo tal y como está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar puesto vacío"):
		  
		  	descripcion.text = "Se ofrece al mejor postor una sábana rancia y unas cajas vacías. ¿Nada? Estais perdiendo la oportunidad de vuestras vidas";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";			  
		  
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
			infoText.text = "Mirar puesto vacío";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir puesto vacío";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar puesto vacío";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el puesto vacío";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al puesto vacío";
		   break;
		  case("Coger"):
			infoText.text = "Coger puesto vacío";
		   break;
		  case("Usar"):
			infoText.text = "Usar puesto vacío";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con puesto vacío";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover puesto vacío";
		   break;
		  case("Dar"):
			infoText.text = "Dar puesto vacío";
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
		  case("Mirar puesto vacío"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir puesto vacío"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar puesto vacío"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el puesto vacío"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al puesto vacío"):
			infoText.text = "Hablar";
		   break;
		  case("Coger puesto vacío"):
			infoText.text = "Coger";
		   break;
		  case("Usar puesto vacío"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con puesto vacío"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover puesto vacío"):
			infoText.text = "Mover";
		   break;
		  case("Dar puesto vacío"):
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

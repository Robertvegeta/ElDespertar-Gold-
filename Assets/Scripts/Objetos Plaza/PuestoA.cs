using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuestoA : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar puesto abierto"):
		  
			descripcion.text = "Pues vaya gracia, ¿ahora abres no?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera());
			//infoText.text = "caminar";

		   break;
		   
		  case("Abrir puesto abierto"):
		  
		  	descripcion.text = "Ya ha abierto";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar puesto abierto"):
		  
		  	descripcion.text = "No, mejor no";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el puesto abierto"):
		  
		  
		   break;
		   
		  case("Hablar al puesto abierto"):
		  
		  	descripcion.text = "Mejor que si quiero algo le hable al tendero";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger puesto abierto"):
		  
		  	descripcion.text = "Eso no tiene demasiado sentido";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
	
		   break;
		   
		  case("Usar puesto abierto"):
		  
		  	descripcion.text = "Ya lo está  usando otro";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar dinero, mucho dinero con puesto abierto"):
		  

			
		   break;		   
		   
		  case("Mover puesto abierto"):
		  
		  	descripcion.text = "Nah, mejor dejarlo tal y como está";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
			//infoText.text = "caminar";	
			
		   break;
		  case("Dar puesto abierto"):
		  
		  	descripcion.text = "Ya le pertenece a él";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
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
			infoText.text = "Mirar puesto abierto";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir puesto abierto";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar puesto abierto";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el puesto abierto";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al puesto abierto";
		   break;
		  case("Coger"):
			infoText.text = "Coger puesto abierto";
		   break;
		  case("Usar"):
			infoText.text = "Usar puesto abierto";
		   break;
		  case("Usar dinero, mucho dinero con "):
			infoText.text = "Usar dinero, mucho dinero con puesto abierto";
		   break;		   
		   
		  case("Mover"):
			infoText.text = "Mover puesto abierto";
		   break;
		  case("Dar"):
			infoText.text = "Dar puesto abierto";
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
		  case("Mirar puesto abierto"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir puesto abierto"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar puesto abierto"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el puesto abierto"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al puesto abierto"):
			infoText.text = "Hablar";
		   break;
		  case("Coger puesto abierto"):
			infoText.text = "Coger";
		   break;
		  case("Usar puesto abierto"):
			infoText.text = "Usar";
		   break;
		  case("Usar dinero, mucho dinero con puesto abierto"):
			infoText.text = "Usar dinero, mucho dinero con ";
		   break;		   
		  case("Mover puesto abierto"):
			infoText.text = "Mover";
		   break;
		  case("Dar puesto abierto"):
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

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Bola : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar bola"):
		  
			descripcion.text = "Es el streaming de las brujas y los magos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir bola"):
		  
		  	descripcion.text = "Como mucho tirarla al suelo pero abrirla...no lo creo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar bola"):
		  
		  	descripcion.text = "No se cierra";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia la bola"):
		  
		  
		   break;
		   
		  case("Hablar a la bola"):
		  
		  	descripcion.text = "Bola mágica, ¿sabes como puedo despertarme de una puta vez?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			//StartCoroutine(Espera2());
			//descripcion.text = "Madre mía, que maleducado";
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger bola"):
		  
		  	descripcion.text = "Ojalá. Siempre he querido una de esas, aunque creo que no me dejará";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar bola"):
		  
		  	descripcion.text = "Me da que el sabrá utilizarla mejor que yo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover bola"):
		  
		  	descripcion.text = "Y me la llevo rodando, ¿no?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar bola"):
		  
		  	descripcion.text = "Ya es suya";
			movimiento.SetActive(false);
			panel.SetActive(true);
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
			infoText.text = "Mirar bola";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir bola";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar bola";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia la bola";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar a la bola";
		   break;
		  case("Coger"):
			infoText.text = "Coger bola";
		   break;
		  case("Usar"):
			infoText.text = "Usar bola";
		   break;
		  case("Mover"):
			infoText.text = "Mover bola";
		   break;
		  case("Dar"):
			infoText.text = "Dar bola";
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
		  case("Mirar bola"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir bola"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar bola"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia la bola"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar a la bola"):
			infoText.text = "Hablar";
		   break;
		  case("Coger bola"):
			infoText.text = "Coger";
		   break;
		  case("Usar bola"):
			infoText.text = "Usar";
		   break;
		  case("Mover bola"):
			infoText.text = "Mover";
		   break;
		  case("Dar bola"):
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
        yield return new WaitForSeconds(3f);
        panel.SetActive(false);
		movimiento.SetActive(true);
     }
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}

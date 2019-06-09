using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Libro5 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar libro rojo"):
		  
			descripcion.text = "El libro se titula: La magia de las aventuras Point&Click";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir libro rojo"):
		  
		  	descripcion.text = "Habla de la época dorada de los videojuegos de aventuras gráficas. Menudos recuerdos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=5;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar libro rojo"):
		  
		  	descripcion.text = "Ya está cerrado";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el libro rojo"):
		  
		  
		   break;
		   
		  case("Hablar al libro rojo"):
		  
		  	descripcion.text = "No suelo hablar con libros, esto me recuerda a Macaulay Culkin en El guardián de las palabras";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger libro rojo"):
		  
		  	descripcion.text = "Ya lo tengo en casa";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=1
			;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar libro rojo"):
		  
		  	descripcion.text = "Pues me haría falta porque menudo destrozo de aventura he hecho";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3
			;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover libro rojo"):
		  
		  	descripcion.text = "De la tienda de Simon, perdón, Timon, no lo moverán";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=3;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar libro rojo"):
		  
		  	descripcion.text = "No puedo dárselo a nadie";
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
			infoText.text = "Mirar libro rojo";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir libro rojo";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar libro rojo";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el libro rojo";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al libro rojo";
		   break;
		  case("Coger"):
			infoText.text = "Coger libro rojo";
		   break;
		  case("Usar"):
			infoText.text = "Usar libro rojo";
		   break;
		  case("Mover"):
			infoText.text = "Mover libro rojo";
		   break;
		  case("Dar"):
			infoText.text = "Dar libro rojo";
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
		  case("Mirar libro rojo"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir libro rojo"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar libro rojo"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el libro rojo"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al libro rojo"):
			infoText.text = "Hablar";
		   break;
		  case("Coger libro rojo"):
			infoText.text = "Coger";
		   break;
		  case("Usar libro rojo"):
			infoText.text = "Usar";
		   break;
		  case("Mover libro rojo"):
			infoText.text = "Mover";
		   break;
		  case("Dar libro rojo"):
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
	 
	IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(3f);
     }
	 
}
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tarro1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
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
			
		  case("Mirar tarro con ojos"):
		  
			descripcion.text = "Hay un montón de ojos flotando en el líquido, quiero creer que no son humanos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";

		   break;
		   
		  case("Abrir tarro con ojos"):
		  
		  	descripcion.text = "No quiero imaginar como huele eso";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";
			
		   break;
		   
		  case("Cerrar tarro con ojos"):
		  
		  	descripcion.text = "Ya está cerrado por suerte";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Caminar hacia el tarro con ojos"):
		  
		  
		   break;
		   
		  case("Hablar al tarro con ojos"):
		  
		  	descripcion.text = "Oix, no me mireis tanto que me ruborizo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";		  
		  
		   break;
		   
		  case("Coger tarro con ojos"):
		  
		  	descripcion.text = "Estaba pensando en coger unos azules o verdes pero no, por desgracia todos son marrones";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Usar tarro con ojos"):
		  
		  	descripcion.text = "No lo necesito para nada";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		   
		  case("Mover tarro con ojos"):
		  
		  	descripcion.text = "Que se quede donde está, que solo faltaría que se esparramara por el suelo";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=4;
			StartCoroutine(Espera());
			infoText.text = "caminar";	
			
		   break;
		  case("Dar tarro con ojos"):
		  
		  	descripcion.text = "Mejor que se lo quede éste para sus experimentos";
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
			infoText.text = "Mirar tarro con ojos";
		   break;
		  case("Abrir"):
			infoText.text = "Abrir tarro con ojos";
		   break;
		  case("Cerrar"):
			infoText.text = "Cerrar tarro con ojos";
		   break;
		  case("Caminar"):
			infoText.text = "Caminar hacia el tarro con ojos";
		   break;
		  case("Hablar"):
			infoText.text = "Hablar al tarro con ojos";
		   break;
		  case("Coger"):
			infoText.text = "Coger tarro con ojos";
		   break;
		  case("Usar"):
			infoText.text = "Usar tarro con ojos";
		   break;
		  case("Mover"):
			infoText.text = "Mover tarro con ojos";
		   break;
		  case("Dar"):
			infoText.text = "Dar tarro con ojos";
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
		  case("Mirar tarro con ojos"):
			infoText.text = "Mirar";
		   break;
		  case("Abrir tarro con ojos"):
			infoText.text = "Abrir";
		   break;
		  case("Cerrar tarro con ojos"):
			infoText.text = "Cerrar";
		   break;
		   case("Caminar hacia el tarro con ojos"):
			infoText.text = "Caminar";
		   break;
		  case("Hablar al tarro con ojos"):
			infoText.text = "Hablar";
		   break;
		  case("Coger tarro con ojos"):
			infoText.text = "Coger";
		   break;
		  case("Usar tarro con ojos"):
			infoText.text = "Usar";
		   break;
		  case("Mover tarro con ojos"):
			infoText.text = "Mover";
		   break;
		  case("Dar tarro con ojos"):
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
	 
}

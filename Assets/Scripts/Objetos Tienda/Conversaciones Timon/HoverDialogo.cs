using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverDialogo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	Text m_Text;
	public GameObject movimiento;
	public GameObject cover;
	public GameObject panel;
	private Text descripcion;
	private Text mago;
	private Animator protagonista;
	public GameObject personaje;
	private Animator magoanim;
	public GameObject timon;	
	public GameObject dialogoM;
	public GameObject dinero;
	public GameObject polvos;
	public Text infoText;
	public GameObject d1;
	public GameObject d2;
	public GameObject d3;
	public GameObject d4;
	
	float number=0;
	
	void Start()
	{
		m_Text = GetComponent<Text>();
		descripcion = panel.GetComponent<Text>();
		mago = dialogoM.GetComponent<Text>();
		protagonista = personaje.GetComponent<Animator>();
		magoanim = timon.GetComponent<Animator>();
	}

	void Update()
	{

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		changeFontColor();
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		m_Text.color = Color.white;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	  switch(m_Text.text){
		  case("¿Un mago por aquí?"):
			Dialogo1();
		   break;
		  case("No sabrás algún truco de magia, ¿verdad?"):

		   break;
		  case("¿A cuánto está el kilo de polvos mágicos?"):

		   break;
		   case("Bueno, nos vemos"):
			descripcion.text = "Bueno, nos vemos";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			protagonista.enabled=true;
			StartCoroutine(Espera2());
		   break;
		  case("Timon no vendrá de timador, ¿no?"):
		  Dialogo2();
		  break;
		  default:
		  
		  break;
	  } 
    		
	}

	public void OnPointerUp(PointerEventData eventData)
	{

	}

	void changeFontColor()
	{
		m_Text.color = Color.blue;

	}
    IEnumerator Espera ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "¿Un mago?, estás delante del hechicero más grande que ha parido el mundo. Ni Gandalf me llega a la suela de los zapatos";
		magoanim.Play("TSpeak");
		dialogoM.SetActive(true);
		panel.SetActive(false);
		number=5;
		protagonista.Play("WaitI");		
		StartCoroutine(Espera3());
     }
    IEnumerator Espera3 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "Creo que ahí te estás viniendo arriba eee, Gandalf son palabras mayores";
		panel.SetActive(true);
		number=3;
		protagonista.Play("TalkI");
		StartCoroutine(Espera4());
     }
	 
    IEnumerator Espera4 ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "No chavalín, un respeto a los mayores, antes que tú yo me he visto envuelto en éste tipo de aventuras";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		number=4;
		StartCoroutine(Espera5());
     }	 
	 
    IEnumerator Espera5 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "¿Aventuras? ¿A que te refieres exactamente?";
		panel.SetActive(true);
		number=3;
		protagonista.Play("TalkI");
		StartCoroutine(Espera6());
     }	 
	 
    IEnumerator Espera6 ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "A que yo era el hechicero más famoso de los videojuegos Point & Click";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		number=3;
		StartCoroutine(Espera7());
     }	
	 
    IEnumerator Espera7 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "¿Si? ¿Me puedes ayudar? Estoy encerrado en lo que se suponga que sea esto y necesito salir";
		panel.SetActive(true);
		number=4;
		protagonista.Play("TalkI");
		StartCoroutine(Espera8());
     }	
	 
    IEnumerator Espera8 ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "Te puedo ayudar, pero si me permites por favor mirar tu menú. Es que me da tanta nostalgía";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		number=4;
		StartCoroutine(Espera9());
     }		
	 
    IEnumerator Espera9 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "Si, claro, lo que sea para salir de aquí";
		panel.SetActive(true);
		number=3;
		protagonista.Play("TalkI");
		StartCoroutine(Espera10());
     }	
	 
    IEnumerator Espera10 ()
     {
        yield return new WaitForSeconds(number);
		descripcion.text = "";		
		panel.SetActive(true);
		protagonista.Play("WaitI");
		cover.GetComponent<CanvasRenderer>().cull=true;
		d1.GetComponent<CanvasRenderer>().cull=true;
		d2.GetComponent<CanvasRenderer>().cull=true;
		d3.GetComponent<CanvasRenderer>().cull=true;
		d4.GetComponent<CanvasRenderer>().cull=true;
		StartCoroutine(Espera11());
     }	
    IEnumerator Espera11 ()
     {
        yield return new WaitForSeconds(1);
		infoText.text = "Dar ";
		StartCoroutine(Espera12());
     }		
    IEnumerator Espera12 ()
     {
        yield return new WaitForSeconds(1);
		infoText.text = "Dar dinero, mucho dinero a";
		StartCoroutine(Espera13());
     }		 
    IEnumerator Espera13 ()
     {
        yield return new WaitForSeconds(1);
		infoText.text = "Dar dinero, mucho dinero a Timon el hechicero";
		StartCoroutine(Espera14());
     }	
    IEnumerator Espera14 ()
     {
        yield return new WaitForSeconds(1);
		mago.text = "Vaya, muchas gracias, lo acepto de buena fe";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		dinero.SetActive(false);
		number=2;
		StartCoroutine(Espera15());
     }		
	   IEnumerator Espera15 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "Serás hijo de puta, ¡devuelveme eso!";
		panel.SetActive(true);
		number=3;
		protagonista.Play("TalkI");
		StartCoroutine(Espera16());
     }	
	 
    IEnumerator Espera16 ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "Anda no llores tanto y llevate éstos polvos mágicos que me dice la bola que los necesitarás";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		polvos.SetActive(true);
		PlayerPrefs.SetInt("polvos", 1);
		number=4;
		StartCoroutine(Espera17());
     }		 
	   IEnumerator Espera17 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		descripcion.text = "Menuda jeta tienes";
		panel.SetActive(true);
		cover.GetComponent<CanvasRenderer>().cull=false;
		d1.GetComponent<CanvasRenderer>().cull=false;
		d2.GetComponent<CanvasRenderer>().cull=false;
		d3.GetComponent<CanvasRenderer>().cull=false;
		d4.GetComponent<CanvasRenderer>().cull=false;
		number=2;
		protagonista.Play("TalkI");
		StartCoroutine(Espera18());
     }		
	IEnumerator Espera18 ()
     {
        yield return new WaitForSeconds(number);
		magoanim.Play("Timon-Pestañeo");
		dialogoM.SetActive(false);
		m_Text.text = "Timon no vendrá de timador, ¿no?";
		panel.SetActive(false);
		protagonista.Play("WaitI");
     }	
	 
    IEnumerator Espera19 ()
     {
        yield return new WaitForSeconds(number);
		mago.text = "No, en verdad viene de otra cosa pero pero no puedo decírtelo por derechos";
		magoanim.Play("TSpeak");
		protagonista.Play("WaitI");		
		dialogoM.SetActive(true);
		panel.SetActive(false);
		polvos.SetActive(true);
		number=4;
		StartCoroutine(Espera18());
     }		 
    IEnumerator Espera2 ()
     {
        yield return new WaitForSeconds(number);
		panel.SetActive(false);
		descripcion.text = "";
		movimiento.SetActive(true);
		protagonista.Play("WalkI");
		cover.SetActive(false);	
     }
	public void Dialogo1(){
			m_Text.text="";
			descripcion.text = "¿Un mago por aquí?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera());
		
	}
	public void Dialogo2(){
			m_Text.text="";
			descripcion.text = "Timon no vendrá de timador, ¿no?";
			movimiento.SetActive(false);
			panel.SetActive(true);
			number=2;
			protagonista.Play("TalkI");
			StartCoroutine(Espera19());
		
	}	
}

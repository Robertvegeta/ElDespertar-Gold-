using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMenuCre : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	Text m_Text;
	public AudioSource audioData;
	Animator anima;
	public GameObject creditext;
	public GameObject fondo;
	public GameObject logo;
	public GameObject nueva;
	public GameObject options;
	public GameObject credits;
	public GameObject salir; 
	public bool credi;


	//public GUIText guitext;

	bool couroutineStarted= false;	

	void Start()
	{
		credi=false;
		m_Text = GetComponent<Text>();
		fondo = GameObject.Find("Background-layer1");
		logo = GameObject.Find("Logo");
		nueva = GameObject.Find("Nueva partida");
		options = GameObject.Find("Opciones");
		credits = GameObject.Find("Créditos");
		credi=credits.GetComponent<Text>();
		salir = GameObject.Find("Salir");
		anima = creditext.GetComponent<Animator>();
	}

	void Update()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		changeFontSize();
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		m_Text.fontSize = 37;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if(!credi){
			//anima.enabled = true;
			fondo.SetActive(false);
			logo.SetActive(false);
			nueva.SetActive(false);
			options.SetActive(false);
			creditext.SetActive(true);
			credits.GetComponent<UnityEngine.UI.Text>().text = "Volver";
			credi= true;		
			salir.SetActive(false);
			StartCoroutine(Espera());
		}
		else{
			fondo.SetActive(true);
			logo.SetActive(true);
			nueva.SetActive(true);
			options.SetActive(true);
			creditext.SetActive(false);
			credits.GetComponent<UnityEngine.UI.Text>().text = "Créditos";
			credi= false;
			salir.SetActive(true);	
			//anima.enabled = false;
			
		}
		
		//guitext.text = number.ToString();
			
	}

	public void OnPointerUp(PointerEventData eventData)
	{

	}
	
	void changeFontSize()
	{
		m_Text.fontSize = 40;
		audioData.Play ();
	}
	
	IEnumerator Espera ()
    {
        yield return new WaitForSeconds(28f);
		fondo.SetActive(true);
		logo.SetActive(true);
		nueva.SetActive(true);
		options.SetActive(true);
		credits.GetComponent<UnityEngine.UI.Text>().text = "Créditos";
		salir.SetActive(true);
		creditext.SetActive(false);		
		//anima.enabled = false;
    }
}
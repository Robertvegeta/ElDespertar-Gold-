using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMenuNew : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	Text m_Text;
	public AudioSource audioData;




	//public GUIText guitext;


	void Start()
	{
		m_Text = GetComponent<Text>();

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
		SceneManager.LoadScene("Plaza");
	}

	public void OnPointerUp(PointerEventData eventData)
	{

	}
	
	void changeFontSize()
	{
		m_Text.fontSize = 40;
		audioData.Play ();
	}
	

}

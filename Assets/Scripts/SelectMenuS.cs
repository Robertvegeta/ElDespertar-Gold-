using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenuS : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	Text m_Text;
	public AudioSource audioData;


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
		PlayerPrefs.DeleteAll();
		Application.Quit();	
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

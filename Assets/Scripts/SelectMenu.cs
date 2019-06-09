//For this script to work, create a new Text GameObject by going to Create>UI>Text. Attach the script to the Text GameObject. Make sure the GameObject has a RectTransform component.

using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	Text m_Text;
	public AudioSource audioData;

	void Start()
	{
		//Fetch the Text and RectTransform components from the GameObject
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
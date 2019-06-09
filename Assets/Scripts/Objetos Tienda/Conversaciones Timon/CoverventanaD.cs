using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class CoverventanaD : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public GameObject movimiento;
	//public AudioSource audioData;


	void Start()
	{
	}

	void Update()
	{

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
			movimiento.SetActive(false);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
			movimiento.SetActive(true);
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		
	}

	public void OnPointerUp(PointerEventData eventData)
	{

	}

}


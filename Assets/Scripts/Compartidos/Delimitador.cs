using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class Delimitador : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	public GameObject movimiento; 


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
	

	
}
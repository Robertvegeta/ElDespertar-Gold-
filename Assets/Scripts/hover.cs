﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

    public Sprite customSprite;
    public Sprite hoverSprite;
    public Sprite pressedSprite;
	public string objectName;
	public GameObject movimiento; 

    private Image button;
	public Text infoText;

    public void Start()
    {
        button = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.sprite = hoverSprite;
		movimiento.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.sprite = customSprite;
		movimiento.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        button.sprite = pressedSprite;
		infoText.text = objectName;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
		//if(buttonRect.Contains(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), true)) {
			button.sprite = hoverSprite;
		//}
		//button.sprite = customSprite;
    }
}

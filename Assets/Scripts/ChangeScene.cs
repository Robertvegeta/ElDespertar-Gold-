using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    void Start()
    {
        Debug.Log("LoadSceneA");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
	
	public void OnPointerDown(PointerEventData eventData)
	{
       // Debug.Log("sceneName to load: " + SampleScene);
        //SceneManager.LoadSceneAsync("Assets/Scenes/others/SampleScene.unity");
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

}
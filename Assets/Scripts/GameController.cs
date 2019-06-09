using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Image character;

	public Animator protagonista;
	public GameObject personaje;
	
	public GameObject delimitador;
	public GameObject alarm;

    private Vector3 targetPosition;
    private Vector3 lastTargetPosition;
	private Vector3 posprotagonista;
    private bool insideCollider;
	public float x;
	public float y;
	public float speed;
	private bool move = false;


   
	// Use this for initialization
	void Start () {
        insideCollider = false;
		protagonista = personaje.GetComponent<Animator>();
		protagonista.Play("WaitL");
		/*active = PlayerPrefs.GetInt("active");
		if(active==1){
			alarm.SetActive(false);
		}*/
	}
	 
	 
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0))
        {
			//protagonista.Play("WalkI");
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			   // x = Input.mousePosition.x;
				//y = Input.mousePosition.y;
			posprotagonista = character.transform.position;
			float pA = Mathf.Sqrt ((Mathf.Pow (posprotagonista.x, 2) + Mathf.Pow (posprotagonista.y, 2)));
			float pB = Mathf.Sqrt((Mathf.Pow(targetPosition.x,2) + Mathf.Pow(targetPosition.y,2)));

			if ((posprotagonista.x - targetPosition.x) > 0) {
				Debug.Log(posprotagonista.x - targetPosition.x);
				protagonista.Play ("WalkI");
				move=false;
			} else {
				Debug.Log(posprotagonista.x - targetPosition.x);
				protagonista.Play ("WalkD");
				move=true;
			}
			if (((posprotagonista.x - targetPosition.x)> -0.2) && ((posprotagonista.x - targetPosition.x)< 0.2)) {
			Parar();
			
			}
        }
			if ((posprotagonista.x - targetPosition.x)== 0) {
			Parar();
			
			}
        // Vamos hacía el objetivo clicado siempre y cuando no haya collider
        if (!insideCollider)
        {
			//protagonista.Play("WalkI");
            character.transform.position = Vector3.MoveTowards(
                    new Vector3(character.transform.position.x, character.transform.position.y, 0),
                    new Vector3(targetPosition.x, targetPosition.y, 0),
                    Time.deltaTime * 7);

            lastTargetPosition = character.transform.position;
			//protagonista.Play("WaitI");
			//Parar();
					
        }
        else {

            // Hacemos moon walker para irnos del collider.
            character.transform.position = Vector3.MoveTowards(
                    new Vector3(character.transform.position.x, character.transform.position.y, 0),
                    new Vector3(-targetPosition.x, -targetPosition.y, 0),
                    Time.deltaTime * 7);
					//Parar();
        }
		/*if (!move){
			Parar();
		}else{
			move=true;
		}*/
    }

    // Evento que se ejecutara remotamente cuando el personaje toque un collider
    public void detectCollider(Vector3 collider)
    {
        insideCollider = true;
        targetPosition = collider;
		Debug.Log("collider collision");
		Parar();
    }

    // Evento que se ejecutara remotamente cuando el personaje salga de un collider
    public void outsideCollider(Vector3 collider)
    {
        insideCollider = false;
        targetPosition = character.transform.position;
		Parar();
    }

    public void Parar(){
		if(!move){
			protagonista.Play("WaitI");
			
		}else{
			protagonista.Play("WaitD");
		}
		
	}

}

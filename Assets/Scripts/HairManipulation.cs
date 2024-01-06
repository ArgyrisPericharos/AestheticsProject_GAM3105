using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairManipulation : MonoBehaviour
{
    public GameObject MouseTracker;
    public GameManager gamemanager;

     //= "What was that?";
    // all the strings above need to be made into scriptable objects and added on the list when called
    public void Awake()
    {
        MouseTracker = GameObject.FindWithTag("MouseTracker");
        gamemanager = GameObject.FindWithTag("Gamemanager").GetComponent<GameManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().Twist == true && this.gameObject.CompareTag("GingerHair"))
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().SwapViewsInList();
                Destroy(this.gameObject);
            }
            
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().SlowPull == true && this.gameObject.CompareTag("GingerHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().StartConvoString);
                gamemanager.GetComponent<GameManager>().DialogueGo = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);

            }
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().FastPull == true && this.gameObject.CompareTag("GingerHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true &&  Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().EndConvoString);
                gamemanager.GetComponent<GameManager>().DialogueGo = false;

                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
        }       
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().FastPull == true && this.gameObject.CompareTag("DarkHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().FastPullDHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false /* also need to be looking if dialogueGO is on or not */  && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }

        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().SlowPull == true && this.gameObject.CompareTag("DarkHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().SlowPullDHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().Twist == true && this.gameObject.CompareTag("DarkHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().TwistDHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().FastPull == true && this.gameObject.CompareTag("GreyHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().FastPullGHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }

        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().SlowPull == true && this.gameObject.CompareTag("GreyHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().SlowPullGHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().Twist == true && this.gameObject.CompareTag("GreyHair"))
        {
            if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == true && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                gamemanager.GetComponent<GameManager>().Dialogues.Insert(0, gamemanager.GetComponent<GameManager>().TwistGHstring);
                gamemanager.GetComponent<GameManager>().InteruptedDialogueAction = true;
                Destroy(this.gameObject);
            }
            else if (gamemanager.GetComponent<GameManager>().SofaRoomCurrent == false && Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
           
        }
        else if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().Remove == true)
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Destroyed");
                Destroy(this.gameObject);
            }
            
        }


    }
}

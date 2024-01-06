using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Principal;

public class GameManager : MonoBehaviour
{
    public bool DialogueGo;
    public float DialogueTimer = 5f;
    public float ResponceTimer = 5f;

    public List<DialoguesSO> Dialogues;
    public TextMeshProUGUI maintext;

    public bool InteruptedDialogueAction;

    public DialoguesSO DHSPResponceString; //= "owowowowo";  change this to a scriptable object that gets added in

    public Button OpenUpFieldButton;
    public Image Field;

    public Image DarkHair, GingerHair, GreyHair;

    public Transform HeadValleyCanvas;

    public GameObject Mousetracker;

    public GameObject Map, MapButton, Inventory, InventoryButton;

    public bool Ginger, Dark, Grey;

    public bool EyeView, HeadView;

    public Camera MainCamera;

    public GameObject SpriteToChangeGO;

    public List<Sprite> RoomViews;

    public DialoguesSO StartConvoString; //= "Hello!";
    public DialoguesSO EndConvoString; //= "Goodbye!";
    public DialoguesSO FastPullDHstring; // = "OUCH!!!";
    public DialoguesSO SlowPullDHstring; //= "OuOuOuchhh!!";
    public DialoguesSO TwistDHstring; //= "Ouuuufuf!!";
    public DialoguesSO FastPullGHstring; // = "EWWWchhh!!";
    public DialoguesSO SlowPullGHstring; //= "WTF!!!!";
    public DialoguesSO TwistGHstring;
    //create a seed tracking float

    //on slow pull you will get those extra seeds that then allow you to groom/plant more hair

    //groom,remove,fp,sp,twist booleans needed and function for their buttons. DONE

    //make "scene" changing buttons, that basically transform the camera -10 or +10 on the x axis everytime. DONE

    //make functions for whenever you interact with the actions with the different booleans turn on. DONE

    //make a list of all hair that are pluckable. DONE

    //make the spawn prefab of grrom and the script that makes you wait until the hair spawns

    //X position of the camera should be put on 23.5o when in eye view. DONE


    public bool Twist, Remove, Groom, SlowPull, FastPull;

    public bool TreeRoomCurrent, SofaRoomCurrent; 
    void Start()
    {
        Ginger = false;
        Dark = true;
        Grey = false;
        HeadView = true;
        EyeView = false;
        InteruptedDialogueAction = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Mousetracker.transform.position = new Vector3(mouseposition.x, mouseposition.y, 0);

        if (EyeView == false && HeadView == true) 
        {
            MainCamera.transform.position = new Vector3 (0, 0, -10);
        }
        else if (EyeView == true && HeadView == false)
        {
            MainCamera.transform.position = new Vector3(23.50f, 0, -10);
        }

        SpriteToChangeGO.GetComponent<SpriteRenderer>().sprite = RoomViews[0]; // change the list to be a list of scriptable objects and in them have colour and string information;

        if (RoomViews[0].name == "Sofa room")
        {
            SofaRoomCurrent = true;
            TreeRoomCurrent = false;
        }
        else if (RoomViews[0].name == "Tree Room")
        {
            SofaRoomCurrent = false;
            TreeRoomCurrent = true;
        }

        maintext.text = Dialogues[0].Entry.ToString();
        maintext.color = Dialogues[0]. ColourEntried;

        if (DialogueGo && SofaRoomCurrent)
        {
            DialogueTimer -= Time.deltaTime;
            maintext.gameObject.SetActive(true);
        } 
        else
        {
            maintext.gameObject.SetActive(false);
        }

        if (DialogueTimer <= 0)
        {
            Dialogues.RemoveAt(0);
            DialogueTimer = 5f;
        }

        if (InteruptedDialogueAction == true)
        {
            maintext.gameObject.SetActive(true);
            DialogueGo = false;
            ResponceTimer -= Time.deltaTime;
            
        }

        if (ResponceTimer <= 0)
        {
            DialogueGo = true;
            InteruptedDialogueAction = false;
            ResponceTimer = 5f;
            Dialogues.Insert(1,DHSPResponceString); 

        }
    }

    public void OpenUpField()
    {
        Image newfield = Instantiate(Field, new Vector3(OpenUpFieldButton.GetComponent<RectTransform>().position.x, OpenUpFieldButton.GetComponent<RectTransform>().position.y, OpenUpFieldButton.GetComponent<RectTransform>().position.z), Quaternion.identity);

        newfield.transform.SetParent(HeadValleyCanvas);

        Image newhair = Instantiate(DarkHair, new Vector3(OpenUpFieldButton.GetComponent<RectTransform>().position.x +- Random.Range(-2,2), OpenUpFieldButton.GetComponent<RectTransform>().position.y +- Random.Range(-2, 2), OpenUpFieldButton.GetComponent<RectTransform>().position.z), Quaternion.identity);

        newhair.transform.SetParent(HeadValleyCanvas);

        Destroy(OpenUpFieldButton.gameObject);

    }

    public void GroomChosen()
    {
        Twist = false;
        Remove = false;
        Groom = true;
        SlowPull = false;
        FastPull = false;
    }
    public void TwistChosen()
    {
        Twist = true;
        Remove = false;
        Groom = false;
        SlowPull = false;
        FastPull = false;
    }
    public void RemoveChosen()
    {
        Twist = false;
        Remove = true;
        Groom = false;
        SlowPull = false;
        FastPull = false;
    }

    public void FastPullChosen()
    {
        Twist = false;
        Remove = false;
        Groom = false;
        SlowPull = false;
        FastPull = true;
    }
    public void SlowPullChosen()
    {
        Twist = false;
        Remove = false;
        Groom = false;
        SlowPull = true;
        FastPull = false;
    }

    public void InventoryOpened()
    {
        Inventory.SetActive(true);
        MapButton.SetActive(false);
    }

    public void InventoryClosed()
    {
        Inventory.SetActive(false);
        MapButton.SetActive(true);
    }

    public void MapOpend()
    {
        Map.SetActive(true);
        InventoryButton.SetActive(false);
        
    }

    public void MapClosed()
    {
        Map.SetActive(false);
        InventoryButton.SetActive(true);
        
    }

    public void GingerChosen()
    {
        Ginger = true;
        Dark = false;
        Grey = false;
    }

    public void DarkChosen()
    {
        Ginger = false;
        Dark = true;
        Grey = false;
    }

    public void GreyChosen()
    {
        Ginger = false;
        Dark = false;
        Grey = true;
    }

    public void EyeViewChosen()
    {
        HeadView = false;
        EyeView = true;

    }

    public void HeadViewChosen()
    {
        HeadView = true;
        EyeView = false;
    } 

    public void SwapViewsInList()
    {
        Sprite SpriteToMove = RoomViews[0];

        RoomViews.RemoveAt(0);

        RoomViews.Insert(1, SpriteToMove);
    }
}

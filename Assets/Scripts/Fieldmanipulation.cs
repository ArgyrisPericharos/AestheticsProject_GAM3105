using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.VersionControl;

public class Fieldmanipulation : MonoBehaviour
{
    public GameObject MouseTracker;
    public GameManager gamemanager;

    public Image HairModuleDark, HairModuleGinger, HairModuleGrey;
    // Start is called before the first frame update
    public void Awake()
    {
        MouseTracker = GameObject.FindWithTag("MouseTracker");
        gamemanager = GameObject.FindWithTag("Gamemanager").GetComponent<GameManager>();
        HairModuleDark = gamemanager.GetComponent<GameManager>().DarkHair;
        HairModuleGinger = gamemanager.GetComponent<GameManager>().GingerHair;
        HairModuleGrey = gamemanager.GetComponent<GameManager>().GreyHair;
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
        if (other.gameObject == MouseTracker.gameObject && gamemanager.GetComponent<GameManager>().Groom == true)
        {   
            if (Input.GetMouseButtonDown(0))
            {
                if (gamemanager.GetComponent<GameManager>().Dark == true)
                {
                    Debug.Log("Grooming");
                    Image newhair = Instantiate(HairModuleDark, new Vector3(MouseTracker.transform.position.x, MouseTracker.transform.position.y, 0), Quaternion.identity);

                    newhair.transform.SetParent(gamemanager.GetComponent<GameManager>().HeadValleyCanvas);
                }
                else if (gamemanager.GetComponent<GameManager>().Ginger == true)
                {
                    Debug.Log("Grooming");
                    Image newhair = Instantiate(HairModuleGinger, new Vector3(MouseTracker.transform.position.x, MouseTracker.transform.position.y, 0), Quaternion.identity);

                    newhair.transform.SetParent(gamemanager.GetComponent<GameManager>().HeadValleyCanvas);
                }
                else if (gamemanager.GetComponent<GameManager>().Grey == true)
                {
                    Debug.Log("Grooming");
                    Image newhair = Instantiate(HairModuleGrey, new Vector3(MouseTracker.transform.position.x, MouseTracker.transform.position.y, 0), Quaternion.identity);

                    newhair.transform.SetParent(gamemanager.GetComponent<GameManager>().HeadValleyCanvas);
                }
               
            }
        }
    }
}

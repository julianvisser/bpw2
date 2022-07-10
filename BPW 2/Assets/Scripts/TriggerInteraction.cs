using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{

    public GameObject player;
    public GameObject prompt;
    public GameObject fade;

    public Vector3 tpOffset;

    private bool playerIsInside = false;

    // Start is called before the first frame update
    void Start()
    {
        //prompt.enabled = false;
        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsInside)
        {
            // Debug.Log("inside");
            //if (Input.GetKeyDown("E"))
            //{
            //    Debug.Log("E pressed");
            //}
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("e pressed");
                player.SetActive(false);
                fade.SetActive(true);
                player.transform.position = player.transform.position + tpOffset;
                player.SetActive(true);
                playerIsInside = false;
            }
        }
    }

    void OnTriggerEnter(Collider player)
    {
        playerIsInside = true;

        // prompt.enabled = true;

        prompt.SetActive(true);
    }

    void OnTriggerExit(Collider player)
    {
        playerIsInside = false;

        // prompt.enabled = false;

        prompt.SetActive(false);
        fade.SetActive(false);
    }
}

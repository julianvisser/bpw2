using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{

    public GameObject fade;
    private float timer = 4f;
    private bool reachedEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedEnd)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }

    void OnTriggerEnter(Collider player)
    {
        fade.SetActive(true);
        reachedEnd = true;
    }
}

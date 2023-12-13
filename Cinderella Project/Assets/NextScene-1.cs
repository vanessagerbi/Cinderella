using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string roomName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       Debug.Log("hit an object");
        if (other.gameObject.CompareTag("Door"))
        {
            Debug.Log("hit a door");
            SceneManager.LoadScene(roomName);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
            SceneManager.LoadScene("Game");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour
{
    
    public void goBacktoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

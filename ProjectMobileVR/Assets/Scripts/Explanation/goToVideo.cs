using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToVideo : MonoBehaviour
{


    public void watchVideo()
    {
        SceneManager.LoadScene(5);
    }

    public void OnPointerExit()
    {
        print("You have gone");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

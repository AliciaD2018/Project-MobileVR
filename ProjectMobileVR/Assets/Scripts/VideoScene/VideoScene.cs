using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoScene : MonoBehaviour
{


    public void goToPolice()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPointerExit()
    {
        print("You have gone...");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuFunctions : MonoBehaviour
{


    //------------------------------------ MAIN MENU FUNCTIONS-----------------------------------------
    public void quitMenu()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }
    public void goToPlay()
    {
        SceneManager.LoadScene(1);
    }


    public void goToDevelopers()
    {
        SceneManager.LoadScene(2);
    }


    public void goToInstructions()
    {
        SceneManager.LoadScene(3);
    }


    //------------------------------------RETURN TO MAIN MENU -----------------------------------------

    public void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }





    public void OnPointerExit()
    {
        print("You just leave...");
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

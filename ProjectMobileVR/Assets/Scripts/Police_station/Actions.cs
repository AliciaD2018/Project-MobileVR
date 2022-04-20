using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour
{

    public AudioSource yaMeHasRespondido;

    public void John()
    {
        SceneManager.LoadScene(8);
    }

    public void Robbie()
    {
        if (static_information.Robbie)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(9);
        }
        
    }

    public void Mario()
    {
        if (static_information.Mario)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(10);
        }
    }

    public void Peter()
    {
        if (static_information.Peter)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(11);
        }
    }
    public void Bruce()
    {
        if (static_information.Bruce)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(12);
        }
    }
    public void Michael()
    {
        if (static_information.Michael)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(13);
        }
    }
    public void Rocky()
    {
        if (static_information.Rocky)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(14);
        }
    }
    public void Arthur()
    {
        if (static_information.Arthur)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(15);
        }
    }
    public void George()
    {
        if (static_information.George)
        {
            yaMeHasRespondido.Play();
        }
        else
        {
            SceneManager.LoadScene(16);
        }
    }




    public void OnPointerExit()
    {
        print("Saliste");
    }


    // Start is called before the first frame update
    void Start()
    {
        if( static_information.Robbie   &&
            static_information.Mario    &&
            static_information.Peter    &&
            static_information.Bruce    &&
            static_information.Michael  &&
            static_information.Rocky    &&
            static_information.Arthur   &&
            static_information.George
            )
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            print("Still not");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

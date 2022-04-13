using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{

    public void Robbie()
    {
        static_information.contador += 10;
        print("Hola soy Robbie " + static_information.contador);
    }

    public void OnPointerExit()
    {
        print("Saliste");
    }


    // Start is called before the first frame update
    void Start()
    {
        //static_information.contador += 10;
        //print("Hola soy Robbie "+ static_information.contador);
        print(static_information.Robbie);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

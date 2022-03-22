using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{

    Animator miCompAnimation;
    private bool m_animar;
    // Start is called before the first frame update
    void Start()
    {
        miCompAnimation= gameObject.GetComponent<Animator>();
        m_animar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_animar)
            CargarAnimacion();
        else
            DetenerAnimacion();
    }

    void CargarAnimacion(){
            miCompAnimation.SetBool("activomenu",true);
    }
    void DetenerAnimacion(){
        miCompAnimation.SetBool("activomenu",false);
    }

    public void setanimar(){
        m_animar = true;
    }
    
    public void desabilitaranimacion(){
        m_animar = false;
    }
}

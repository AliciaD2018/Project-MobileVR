using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class actions_rocky : MonoBehaviour
{
    public AudioSource audioYes;
    public AudioSource audioNot;
    public AudioSource audioNotBack;

    public void opcionErronea()
    {
        TextMeshProUGUI textMesH = GameObject.Find("bg_image/hmmm").GetComponent<TextMeshProUGUI>();
        textMesH.text = "Hmmmm nop, try again";
        audioNot.Play();
    }

    public void opcionCorrecta()
    {
        TextMeshProUGUI textMesH = GameObject.Find("bg_image/hmmm").GetComponent<TextMeshProUGUI>();
        textMesH.text = "Good answer, you can\ngo back to main room";

        audioYes.Play();
        static_information.Rocky = true;

    }

    public void goBack()
    {
        if (static_information.Rocky)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            audioNotBack.Play();
        }
    }


    public void OnPointerExit()
    {
        print("Salió del option");
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = GameObject.Find("bg_image/goBack");
        //obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

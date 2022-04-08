using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButton : MonoBehaviour
{
 private Button m_button = null;
 private Image m_image = null;

 public void Constructor(Option option, Action<Option> callback){
     
 }

}


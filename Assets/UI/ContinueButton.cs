using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public void OnClick()  
    {
        SceneManager.LoadScene("Main Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Buttton : MonoBehaviour
{
    public void OnClick()  
    {
        SceneManager.LoadScene("Level 2");
    }
}

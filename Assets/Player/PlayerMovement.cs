using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
    float HMovement;
    public float MaxX = 111f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HMovement = Input.GetAxis("Horizontal");
        if ((HMovement < 0 && transform.position.x > -MaxX) || (HMovement > 0 && transform.position.x < MaxX)) {transform.position += new Vector3(HMovement * Speed * Time.deltaTime, 0f , 0f);}  
    }   
}

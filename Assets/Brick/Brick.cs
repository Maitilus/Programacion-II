using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int BrickHealth;
    public Score AddScore;
    void Update()
    {
        if (BrickHealth == 3) {gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0, 255);}
        else if (BrickHealth == 2) {gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 0, 255);}
        else if (BrickHealth == 1) {gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);}

        if (BrickHealth <= 0) 
        {
            Object.Destroy(gameObject);
            AddScore.CurrentScore += 2;
        }
    }
    private void OnCollisionEnter2D(Collision2D Collide)
    {
        if (Collide.gameObject.CompareTag("Ball")) {BrickHealth -= 1;}
    }
}

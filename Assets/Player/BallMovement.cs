using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public Vector2 InitialSpeed;
    private Rigidbody2D BallRB;
    bool IsMoving;
    public Score AddScore;
    private GameObject[] BrickAmmount;

    void Start()
    {
        BallRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!IsMoving)
        {
            BallRB.velocity = InitialSpeed;
            IsMoving = true;
        }

        BrickAmmount = GameObject.FindGameObjectsWithTag("Brick");
        if (BrickAmmount.Length <= 0) {SceneManager.LoadScene("Win");}
    }

    private void OnCollisionEnter2D(Collision2D Collide)
    {
        if (Collide.gameObject.CompareTag("Killzone")) {SceneManager.LoadScene("Lose");}

        if (Collide.gameObject.CompareTag("Brick")) {AddScore.CurrentScore++;}
    }
}

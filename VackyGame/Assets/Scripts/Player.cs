using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float turnSpeed;

    public int health;
    public int score;
    public TMP_Text healthDisplay;
    public TMP_Text scoreDisplay;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }

    public void TakeDamage()
    {
        health--;
        healthDisplay.text = "Health: " + health;
        if (health <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void AddScore()
    {
        score--;
        scoreDisplay.text = "Score: " + score;
    }
}
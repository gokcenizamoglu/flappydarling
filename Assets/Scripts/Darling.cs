using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darling : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D _rigidbody2D;
    public GameManager managerGame;
    public GameObject DeathScreen;

    void Start()
    {
        DeathScreen.SetActive(false);
        Time.timeScale = 1;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.velocity = Vector2.up * velocity;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }
}

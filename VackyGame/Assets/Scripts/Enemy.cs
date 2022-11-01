using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Player _player;
    private bool _inactive;

    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, _player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_inactive == false)
        {
            if (other.tag == "Hole")
            {
                Destroy(gameObject);
                _player.AddScore();
            }
            else if (other.tag == "Player" || other.tag == "Enemy")
            {
                _player.TakeDamage();
                speed = 0;
                transform.parent = _player.transform;
            }

            _inactive = true;
        }
    }
}
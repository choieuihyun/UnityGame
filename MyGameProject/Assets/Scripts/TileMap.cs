using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{

    /*public int health;
    public int score;

    public bool isDead;

    public Sprite[] sprites;

    void Awake()
    {
        

        //rigid = GetComponent<Rigidbody2D>();
        //rigid.velocity = Vector2.down * speed; // 속도는 velocity, 2D라 Vector2
    }

    void Update()
    {
        
    }

    void OnHit(int dmg)
    {
        health -= dmg;
        sprite[0] = sprites[1];
        Invoke("ReturnSprite", 0.1f); // Invoke가 시간차 함수고 함수명은 문자열로 써야함.

        if (health <= 0 && !isDead)
        {
            isDead = true;
            //Player playerLogic = player.GetComponent<Player>();
            //playerLogic.score += enemyScore;
            Destroy(gameObject); // gameObject가 자기자신, 왜? 이 스크립트를 붙였으니까
            Debug.Log("처치");
        }
    }

    void ReturnSprite()
    {
        sprites[1] = sprites[0];
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Melee")
        {
            Melee melee = collision.gameObject.GetComponent<Melee>(); // Bullet 스크립트를 가져옴
            OnHit(melee.dmg);

            Destroy(collision.gameObject);
        }
    }*/
}

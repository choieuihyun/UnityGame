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
        //rigid.velocity = Vector2.down * speed; // �ӵ��� velocity, 2D�� Vector2
    }

    void Update()
    {
        
    }

    void OnHit(int dmg)
    {
        health -= dmg;
        sprite[0] = sprites[1];
        Invoke("ReturnSprite", 0.1f); // Invoke�� �ð��� �Լ��� �Լ����� ���ڿ��� �����.

        if (health <= 0 && !isDead)
        {
            isDead = true;
            //Player playerLogic = player.GetComponent<Player>();
            //playerLogic.score += enemyScore;
            Destroy(gameObject); // gameObject�� �ڱ��ڽ�, ��? �� ��ũ��Ʈ�� �ٿ����ϱ�
            Debug.Log("óġ");
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
            Melee melee = collision.gameObject.GetComponent<Melee>(); // Bullet ��ũ��Ʈ�� ������
            OnHit(melee.dmg);

            Destroy(collision.gameObject);
        }
    }*/
}

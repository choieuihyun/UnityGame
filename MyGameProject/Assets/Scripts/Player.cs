using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isTouchTile;

    public float rotateSpeed = 5f; // 캐릭터 회전속도
    public int speed; //스피드
    public float atkspeed;
    Animator animator;

    public float maxShotDelay;
    public float curShotDelay;

    public Transform pos;
    public Transform[] HitPoint;
    public Vector2 boxSize;

    public LayerMask whatisGround;

    public JoystickValue value;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        SetAttackSpeed(1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }

    void SetAttackSpeed(float attackspeed)
    {
        animator.SetFloat("atkspeed", attackspeed);
        atkspeed = attackspeed;
    }

    void Move()
    {
            transform.Translate(value.joyTouch);
    }

    /*void Move()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x축으로 이동할 양
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y축으로 이동할양
        this.transform.Translate(new Vector3(xMove, yMove, 0));  //이동

        if (xMove > 0 || xMove < 0)
        {
            animator.SetBool("moving", true);
        }
        else if (yMove > 0 || yMove < 0)
        {
            animator.SetBool("moving", true);
        }
        else
            animator.SetBool("moving", false);
    }*/

    void Attack()
    {
        if (curShotDelay <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Z) && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1"))
            {
                animator.SetTrigger("attack");
                curShotDelay = maxShotDelay;
            }
        }
        else
        {
            curShotDelay -= Time.deltaTime;
        }
    }


    /*void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }*/

    public void Dig ()
    {
        for (int i = 0; i < HitPoint.Length; i++)
        {
            Collider2D overCollider2d = Physics2D.OverlapCircle(HitPoint[i].position, 0.01f, whatisGround);
            if (overCollider2d != null)
            {
                
                overCollider2d.transform.GetComponent<Bricks>().MakeDot(HitPoint[i].position);
                Debug.Log("닿음");
                break;
            }
        }
    }
}

    
  


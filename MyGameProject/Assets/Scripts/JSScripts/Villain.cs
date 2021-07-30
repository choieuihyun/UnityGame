using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : Character
{
    void Update()
    {
        startPos = new Vector2Int((int)gameObject.transform.position.x,
            (int)gameObject.transform.position.y);
        targetPos = new Vector2Int((int)target.transform.position.x,
            (int)target.transform.position.y);
        if (hp <= 0)
            Destroy(gameObject);
        switch (curState)
        {
            case State.Tracing:
                Trace();
                break;
            case State.Attacking:
                if (!Delay)
                {
                    Delay = true;
                    StartCoroutine("Attack");
                }
                break;
        }
    }
}

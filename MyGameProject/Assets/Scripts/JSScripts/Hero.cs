using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : Character {

    public static Hero instance;
    public float AtkBuff = 1;
    public float HpBuff = 50;

    public List<BaseBuff> onBuff = new List<BaseBuff>();

    private void Awake()
    {
        instance = this;
    }

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



    public float BuffChange(string type, float origin)
    {
        if (onBuff.Count > 0)
        {
            float temp = 0;
            for (int i = 0; i < onBuff.Count; i++)
            {
                if (onBuff[i].type.Equals(type))
                    temp += origin * onBuff[i].percentage;
            }
            return origin + temp;
        }
        else
        {
            return origin;
        }
    }

    public void ChooseBuff(string type)
    {
        switch (type)
        {
            case "Atk":
                dmg = BuffChange(type, AtkBuff);
                break;
            case "Def":
                hp = BuffChange(type, HpBuff);
                break;
        }
    }
}


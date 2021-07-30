using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject p;
    public int speed = 30;
    public int damage;

    void Update()
    {
        if (p.gameObject.transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            transform.RotateAround(p.transform.position + new Vector3(2, 0, 0), new Vector3(0, 0, 3), speed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(p.transform.position + new Vector3(2, 0, 0), new Vector3(0, 0, -3), speed * Time.deltaTime);
        }
        StartCoroutine("gone");
    }
    IEnumerator gone()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }


}

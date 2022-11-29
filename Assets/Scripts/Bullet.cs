using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D coll)
{
    GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
    Destroy(effect, 0.5f);
    Destroy(gameObject);

    if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
        }
}


}

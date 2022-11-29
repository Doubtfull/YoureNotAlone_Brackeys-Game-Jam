using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_ai : MonoBehaviour
{

    public float speed;
    public Transform target;
    public float minimumDistance;

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) > minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        

    }   
        void OnCollisionEnter2D(Collision2D coll) {
            if (coll.gameObject.name == "Player")
            {
                FindObjectOfType<AudioManager>().Play("DedSound");
                PlayerDied();
                Destroy(coll.gameObject);
            }
        }

    private void PlayerDied() {
        Game_Manager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
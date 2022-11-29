using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Ed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [Range(100, 1000)]
    public float bounceHeight;

    private void OnCollisionEnter(Collision collision)
    {
       switch(collision.gameObject.tag)
        {
            case "Cloud":
                bounceHeight = 1000f;
                break;
            case "Ground":
                bounceHeight = 550f;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAnimation : MonoBehaviour
{
    public Animator planeAnim;
    public Animator columnAnim;

    private void OnTriggerEnter(Collider other)
    {
        planeAnim.SetBool("isOpening", true);
        columnAnim.SetBool("isOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        planeAnim.SetBool("isOpening", false);
        columnAnim.SetBool("isOpening", false);
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

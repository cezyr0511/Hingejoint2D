using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooking : MonoBehaviour
{
    HookControl Hookcon;
    public DistanceJoint2D joint2D;

    // Start is called before the first frame update
    void Start()
    {
        Hookcon = GameObject.Find("Player").GetComponent<HookControl>();
        joint2D = GetComponent<DistanceJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ceiling"))
        {
            Hookcon.isAttach = true;
            joint2D.enabled = true;
        }
    }
}

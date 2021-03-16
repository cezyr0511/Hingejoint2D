using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCreate : MonoBehaviour
{
    public GameObject Rope;
    public int iCount;
    public Rigidbody2D Pointrb;
    FixedJoint2D exJoint;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < iCount; i++)
        {
            FixedJoint2D currentJoint = Instantiate(Rope).GetComponent<FixedJoint2D>();

            if (i == 0)
            {
                currentJoint.connectedBody = Pointrb;
            }
            else
            {
                currentJoint.connectedBody = exJoint.GetComponent<Rigidbody2D>();
            }

            exJoint = currentJoint;

            if (i == iCount - 1)
            {
                currentJoint.GetComponent<Rigidbody2D>().mass = 10;
                currentJoint.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

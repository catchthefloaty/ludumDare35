using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour
{
    public bool used = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            player temp = col.GetComponent<player>();
            if (temp.form == 1)
            {
                if (!temp.carrying)
                {
                    if (!used)
                    {
                        if (!temp.justDropped)
                        {
                            if (Input.GetAxis("A") > 0)
                            {
                                transform.parent = col.transform;
                                GetComponent<Collider>().enabled = false;
                                GetComponent<Rigidbody>().isKinematic = true;
                                temp.carrying = true;
                                temp.pickedUpLastFrame = true;
                                temp.carriedObject = gameObject;
                                temp.pickupTime = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{
    public float frameTime;
    public Mesh[] meshes;
    float curTime = 0;
    public float speed = 1;
    int curFrame = 0;
    public float rotSpeed = 4;
    public int form = 0;
    public bool grounded = false;
    public bool carrying = false;
    public GameObject carriedObject;
    public GameObject rift;

    public bool pickedUpLastFrame = false;
    public float pickupTime;
    float pickupLimit = .8f;
    public bool justDropped = false;
    float dropTime;
    float dropLimit = .8f;


    bool justConverted = false;
    float convertTime;
    float convertLimit = 1;

    float jumpTime = 1;
    float jumpLimit = 1;

    //public Vector3 currentVector;
    //public GameObject graphic;


    //GameObject camera;
    // Use this for initialization
    void Start()
    {
        //camera = GameObject.FindGameObjectWithTag("cameraRig");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(camera.transform.position,Vector3.up);
        if (form == 0) {
            jumpTime += Time.deltaTime;

            if (grounded)
            {
                if (Input.GetAxis("A") > 0)
                {
                    if (jumpTime > jumpLimit)
                    {
                        GetComponent<Rigidbody>().AddForce(0, 8, 0, ForceMode.Impulse);
                        grounded = false;
                        jumpTime = 0;
                    }
                }

                //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);



            GetComponent<Rigidbody>().AddForce((Input.GetAxis("Horizontal") * speed * Time.deltaTime * 5f) * rift.transform.right.normalized, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddForce(( Input.GetAxis("Vertical") * speed * Time.deltaTime * 5f )* rift.transform.forward.normalized, ForceMode.Impulse);
           

            }
             if (Input.GetAxis("B") > 0) {
                if (!justConverted)
                {
                    form = 1;
                    GetComponent<MeshFilter>().mesh = meshes[1];
                    justConverted = true;
                    convertTime = 0;
                }
            }
            if (justConverted)
            {
                convertTime += Time.deltaTime;
                if (convertTime > convertLimit)
                {
                    justConverted = false;
                }
            }
        }
        else if (form == 1) {
            if (Input.GetAxis("A") > 0)
            {
                if (carrying && !pickedUpLastFrame) {

                    carriedObject.GetComponent<Rigidbody>().isKinematic = false;

                    carriedObject.transform.parent = null;

                    carriedObject.GetComponent<Collider>().enabled = true;
                    carriedObject.transform.Translate(0, 2, 0, Space.World);

                    carrying = false;

                    carriedObject = null;
                    justDropped = true;
                    dropTime = 0;

                }

            }
            pickupTime += Time.deltaTime;
            if (pickupTime > pickupLimit) {
                pickedUpLastFrame = false;
            }
            if (justDropped) {
                dropTime += Time.deltaTime;
                if (dropTime > dropLimit) {
                    //dropTime = 0;
                    justDropped = false;
                }
            }
            //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);


            GetComponent<Rigidbody>().AddForce((Input.GetAxis("Horizontal") * speed * Time.deltaTime ) * rift.transform.right.normalized, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddForce((Input.GetAxis("Vertical") * speed * Time.deltaTime ) * rift.transform.forward.normalized, ForceMode.Impulse);
            if (Input.GetAxis("B") > 0)
            {
                if (!justConverted)
                {
                    form = 0;
                    GetComponent<MeshFilter>().mesh = meshes[0];
                    justConverted = true;
                    convertTime = 0;
                }

            }
            if (justConverted) {
                convertTime += Time.deltaTime;
                if (convertTime > convertLimit) {
                    justConverted = false;
                }
            }
        }
            
        //graphic.transform.position = transform.position;
        //graphic.transform.Rotate(new Vector3(0, 0, -1 * Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime), Space.World);

    }

    
}

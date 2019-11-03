using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowmovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    private float originalPosition;
    //private Rigidbody bow;
    private bool dirRight = true;
    void Start()
    {
        //bow = GetComponent<Rigidbody>();
        originalPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        print(transform.position.ToString());
        /*
            print(Input.GetAxis("Horizontal"));
            if ((Input.GetAxis("Horizontal") < 0) && ((transform.position.z - originalPosition) >= 13))
            {

                transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);

            }
            else if ((Input.GetAxis("Horizontal") > 0) && ((transform.position.z - originalPosition) <= -1))

            {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
                    
            }*/
        print(Input.GetAxis("Horizontal"));
        if ((Input.GetAxis("Horizontal") < 0) && ((transform.position.z - originalPosition) >= -1))
        {

            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);

        }
        else if ((Input.GetAxis("Horizontal") > 0) && ((transform.position.z - originalPosition) <= 13))

        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        }
        
    }
}

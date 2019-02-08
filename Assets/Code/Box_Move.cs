using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Move : MonoBehaviour
{

    public bool move0 = false;
    public bool move1 = false;
    private float Poz_x, Poz_y ,Poz_z;

    private float Sq=26, r=13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z);
        //transform.Translate(Vector3.down);//* Time.fixedDeltaTime);
        if (move0 & transform.position.y == 1)
        {
            //transform.position = Vector3.down;
            // transform.Translate(Vector3.down*Time.fixedDeltaTime);
            Poz_y = -transform.position.y;
            transform.position = new Vector3(transform.position.x, Poz_y, transform.position.z);
            move0 = false;

        }
        else
        {            
           move1 = true; 
        }


        if (move1 & transform.position.y == -1)
        {
                    Poz_x = Random.value * Sq - r;
                    Poz_z = Random.value * Sq - r;
                    transform.position = new Vector3(Poz_x, -transform.position.y, Poz_z);
                    move1 = false;             
        }
    }


         void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("line"))
        { move0 = true;  }
    }
}

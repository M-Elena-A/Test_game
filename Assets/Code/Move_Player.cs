using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour
{
    //public float sped = 50f;
    //double x;
    //float yPoz, xPoz = -7f;

    // Start is called before the first frame update
    void Start()
    {
        //yPoz = transform.position.y;
       //xPoz = transform.position.x;
    }
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public bool move_1 = true;
    public int kill_box=0;

    void Update()
    {

       
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
        if (!(gameObject.transform.position.x > -13.5 & gameObject.transform.position.x < 13.5 &
            gameObject.transform.position.z > -13.5 & gameObject.transform.position.z < 13.5))
        {
            translation = Input.GetAxis("Vertical") * (-1F);
        }
       // else
       //{ translation = Input.GetAxis("Vertical") * (-1F); }
      
            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotation, 0);
        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(5,2,1000,1000),"Уничтожено кубиков: "+ kill_box);

        if (kill_box>=50)
        { GUI.Label(new Rect(5, 2, 1000, 1000), "Уничтожено кубиков: " + kill_box+ "\n Возмите меня на стажировку, пожалуйста."); }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("walls"))
        { kill_box++; }
    }

    }
 /*
    fence
    // Update is called once per frame
    void Update()
    {
        yPoz += sped * Input.GetAxis("Horizontal") * Time.fixedDeltaTime;
        xPoz += sped * Input.GetAxis("Horizontal") * Time.fixedDeltaTime;
        transform.position = new Vector3(xPoz, yPoz, transform.position.z);
    }
    */


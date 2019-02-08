using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controll : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset;
    

    // Start is called before the first frame update
    void Start()
    {
        offset = Player.transform.position - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Player.transform.position - offset;

        float rotation = Input.GetAxis("Horizontal") * 100.0F* Time.deltaTime;
        transform.Rotate(0, rotation, 0);

    }
}

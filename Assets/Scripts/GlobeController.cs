using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveX;
    private float moveZ;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.rotation *= Quaternion.Euler(new Vector3(moveX, 0, moveZ));
    }
}

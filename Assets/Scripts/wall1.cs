using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall1 : MonoBehaviour
{
    public float wall1speed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(wall1speed * Time.deltaTime,0f,0f);
    }
}

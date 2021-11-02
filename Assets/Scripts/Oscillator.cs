using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * speed);
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);

    }

     public void ToggleVisibility()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if(rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Rotator : MonoBehaviour
// {

//     private float rotZ;
//     public float RotationSpeed;
//     public bool ClockWiseRotation;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(ClockWiseRotation == false)
//         {
//             rotZ += Time.time * RotationSpeed;
//         }
//         else
//         {
//             rotZ += -Time.time * RotationSpeed;
//         }
//         transform.rotation = Quaternion.Euler(0, 0, rotZ);
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    private float rotZ;
    public float RotationSpeed = 10;
    public bool ClockWiseRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ClockWiseRotation == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}

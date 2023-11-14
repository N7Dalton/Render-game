using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float RandomX;
    private float RandomY;
    private float RandomZ;
    private float RandomW;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        RandomX = Random.Range(0,360);
        RandomY = Random.Range(0, 360);
        RandomZ = Random.Range(0, 360);
        RandomW = Random.Range(0, 360);

        gameObject.transform.rotation = new Quaternion(RandomX, RandomY, RandomZ, RandomW);
    }
}

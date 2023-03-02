using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestScript: MonoBehaviour
{
    float notTestNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        notTestNum += 1;
        print(notTestNum); 
        notTestNum = -12;
        print(notTestNum);
    }

    // Update is called once per frame
    void Update()
    {
        notTestNum += 0.1f;
        print(notTestNum);
    }
}

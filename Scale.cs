using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scale : MonoBehaviour
{
    public float SizeChange;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = transform.localScale + new Vector3(SizeChange,SizeChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

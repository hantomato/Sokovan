using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    private Color originColor;
    public bool isOveraped = false;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            originColor = myRenderer.material.color;
            myRenderer.material.color = Color.red;
            isOveraped = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            //originColor = myRenderer.material.color;
            myRenderer.material.color = originColor;
            isOveraped = false;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            //originColor = myRenderer.material.color;
            myRenderer.material.color = originColor;
            isOveraped = true;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoChanger : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Color[] colors;
    public int index;
    public float timer;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {
        
    }

    private void OnMouseDown()
    {
        
        //Invoke("ChangePositionAndScale", 1.0f);
        //Invoke(nameof(ChangePositionAndScale),1.0f);
       InvokeRepeating(nameof(ChangePositionAndScale), timer, timer);
        rb.useGravity = true;
    }

    private void OnMouseUp()
    {
        
    }

    private void OnMouseEnter()
    {
        meshRenderer.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnMouseExit()
    {
        
    }

    private void OnMouseDrag()
    {
        
    }

    public void ChangePositionAndScale()
    {
        transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        float randp = Random.Range(-5, 5);
        float rands = Random.Range(1, 5);
        transform.localScale = new Vector3(rands, rands, rands);
        

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShipInput))]
public class ShipEngine : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;
    [SerializeField]
    private float turnSpeed = 5f;

    private ShipInput shipInput;

    private Rigidbody2D rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        shipInput = GetComponent<ShipInput>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(new Vector2(0, shipInput.Vertical * Time.deltaTime * speed));
        transform.Rotate(Vector3.back * shipInput.Horizontal * turnSpeed * Time.deltaTime);
    }
}

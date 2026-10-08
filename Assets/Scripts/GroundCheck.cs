using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] Movement movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.grounded = Physics2D.OverlapAreaAll(movement.groundCheck.bounds.min, movement.groundCheck.bounds.max, movement.groundLayer).Length > 0;
    }
}

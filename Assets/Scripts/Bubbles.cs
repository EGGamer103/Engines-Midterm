using UnityEngine;

public class Bubbles : Factory
{
    [SerializeField] GameObject bubblePrefab;
    [SerializeField] float bubbleSpeed = 5f;
    public override void Create(Transform spawn)
    {
        var bubble = Instantiate(bubblePrefab, spawn.position, Quaternion.identity);
        bubble.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(bubbleSpeed * Mathf.Sign(spawn.localScale.x), 0f);
    }
}
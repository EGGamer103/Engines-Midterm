using UnityEngine;

public class BaseFactory : MonoBehaviour
{
    [SerializeField] GameObject bubblePrefab;
    [SerializeField] float bubbleSpeed = 5f;
    public void ShootBubbles(Transform spawn)
    {
        var bubble = Instantiate(bubblePrefab, spawn.position, Quaternion.identity);
        bubble.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(bubbleSpeed * Mathf.Sign(spawn.localScale.x), 0f);
    }
}

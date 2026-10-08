using UnityEngine;

public class BaseFactory : MonoBehaviour
{
    [SerializeField] Bubbles Bubbles;
    //[SerializeField] ;
    public void ShootBubbles(Transform spawn)
    {
        Bubbles.Create(spawn);
    }
}

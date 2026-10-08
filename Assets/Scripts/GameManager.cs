using UnityEngine;

public class GameManager<T> : MonoBehaviour
{
    private static GameManager<T> _instance;
    public static GameManager<T> Instance;

    public int points;
    public int level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            Instance = _instance;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
}

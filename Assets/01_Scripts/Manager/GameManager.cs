using UnityEngine;

public class GameManager : MonoBehaviour
{
    //싱글톤 선언
    public static GameManager Instance { get; private set; }
    
    public Character character { get; set; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}

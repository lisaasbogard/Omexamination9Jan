using UnityEngine;

public class RespawnFromFall : MonoBehaviour
{
    private Vector3 respawnPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        respawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6f)
        {
            transform.position = respawnPosition;
            print("respawn player");
        }
    }
}

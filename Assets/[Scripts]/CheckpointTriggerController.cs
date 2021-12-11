using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTriggerController : MonoBehaviour
{

    public Transform spawnPoint;

    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.SetCurrentSpawnPoint(spawnPoint);
        }
    }
}

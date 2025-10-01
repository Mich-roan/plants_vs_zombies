using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField]
    private InstantiatePoolObject coinPool;
    [SerializeField]
    private LaneManager laneManager;
    [SerializeField]
    private float spawnInterval = 3f;
    private Coroutine spawnCoroutine;
    private bool isActive = false;
    public void Activate(bool active)
    {
        isActive = active;
        if (isActive)
        {
            spawnCoroutine = StartCoroutine(SpawnCoins());
        }
        else
        {
            if (spawnCoroutine !=null)
        }
    } 
}

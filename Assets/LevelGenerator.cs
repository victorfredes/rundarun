using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    /*
    [Header("Dependencies")]
    [SerializeField] private Transform playerTransform; // Para saber dónde está el jugador

    [Header("Level Chunks")]
    [SerializeField] private GameObject[] levelChunkPrefabs; // Array con todos nuestros prefabs
    [SerializeField] private float chunkLength = 20f; // El largo de cada chunk. ¡Debe ser consistente!
    
    [Header("Generation Settings")]
    [SerializeField] private int initialChunksOnScreen = 5; // Cuántos chunks generar al inicio
    [SerializeField] private int chunksToStayAhead = 3; // Cuántos chunks de ventaja mantener sobre el jugador

    private Vector3 nextSpawnPoint;
    private List<GameObject> activeChunks = new List<GameObject>();

    void Start()
    {
        // Posición inicial para el primer chunk
        nextSpawnPoint = Vector3.zero;

        // Generamos los chunks iniciales para que el jugador tenga un camino
        for (int i = 0; i < initialChunksOnScreen; i++)
        {
            SpawnChunk();
        }
    }

    void Update()
    {
        // Si el jugador se acerca al final del camino generado...
        if (playerTransform.position.x > nextSpawnPoint.x - (chunksToStayAhead * chunkLength))
        {
            SpawnChunk();
            DestroyOldestChunk();
        }
    }

    private void SpawnChunk()
    {
        // Elegimos un chunk al azar de nuestra lista de prefabs
        int randomIndex = Random.Range(0, levelChunkPrefabs.Length);
        
        // Creamos una instancia de ese prefab en la posición de spawn
        GameObject newChunk = Instantiate(levelChunkPrefabs[randomIndex], nextSpawnPoint, Quaternion.identity);
        
        // Lo añadimos a nuestra lista de chunks activos
        activeChunks.Add(newChunk);
        
        // Actualizamos la posición para el siguiente chunk
        nextSpawnPoint.x += chunkLength;
    }

    private void DestroyOldestChunk()
    {
        // Si ya hay demasiados chunks, eliminamos el más antiguo (el primero de la lista)
        if (activeChunks.Count > initialChunksOnScreen + 1)
        {
            GameObject chunkToDestroy = activeChunks[0];
            activeChunks.RemoveAt(0);
            Destroy(chunkToDestroy);
        }
    }
    */
}
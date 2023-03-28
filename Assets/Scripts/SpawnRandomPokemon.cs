using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPokemon : MonoBehaviour
{
    public GameObject[] pokemonPrefabs; // Array of Pokemon prefabs to choose from
    public Transform spawnPoint; // The spawn point where the Pokemon will be instantiated
    public float yRotation = 270f; // The rotation angle on the Y axis
    [HideInInspector] public GameObject pokemon;

    public void SpawnPokemon()
    {
        int index = Random.Range(0, pokemonPrefabs.Length); // Choose a random index from the array
        pokemon = Instantiate(pokemonPrefabs[index], spawnPoint.position, Quaternion.identity); // Instantiate the selected Pokemon at the spawn point
        pokemon.transform.Rotate(0f, yRotation, 0f); // Rotate the Pokemon on the Y axis
    }
}


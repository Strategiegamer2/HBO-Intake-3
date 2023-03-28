using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEncounters : MonoBehaviour
{
    public float encounterChance = 0.1f; // Probability of a random encounter

    private bool isInTallGrass = false; // Flag to check if the player is in tall grass
    public MeshCollider grassCollider; // Reference to the mesh collider of the tall grass

    private float randomNumber;

    void Start()
    {
        randomNumber = Random.Range(0f, 1f);
    }

    void Update()
    {
        if (isInTallGrass && randomNumber < encounterChance)
        {
            // Player has encountered a wild Pokemon!
            StartBattle();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Grass")
        {

            Debug.Log("Tall grass");

            isInTallGrass = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Grass")
        {
            randomNumber = Random.Range(0f, 1f);

            isInTallGrass = false;
        }
    }

    void StartBattle()
    {
        BattleSystem battleSystem = FindObjectOfType<BattleSystem>();
        if (battleSystem != null)
        {
            battleSystem.StartBattle();
        }

        gameObject.SetActive(false);
    }
}

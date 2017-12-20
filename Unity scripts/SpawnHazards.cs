using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHazards : MonoBehaviour {

    #region Variables
    //Public

    //Private
    [SerializeField]
    public float minX = 0.0f;                   //MinX spawn Hazard
    [SerializeField]
    public float maxX = 0.0f;                   //MaxX spawn Hazard
    [SerializeField]
    private GameObject[] hazards;               //potentiele array vn hazards
    [SerializeField]
    private float timeBetweenSpawns = 0.0f;
    private bool canSpawn = false;              //delay posb.
    private int amountOfHazardsToSpawn = 0;
    private int hazardToSpawn = 0;
    #endregion

    #region UnityFunctions
    public void Start()
    {
        canSpawn = true;                        //Temp start
    }
    public void Update()
    {
        if(canSpawn == true)
        {
            StartCoroutine("GenerateHazard");   //start hazard Gen functie
        }
    }
    #endregion

    private IEnumerator GenerateHazard()
    {
        canSpawn = false;
        timeBetweenSpawns = Random.Range(0.5f, 2.5f);       //Test waardes afstand tussen blokken per X.
        amountOfHazardsToSpawn = Random.Range(1, 2);        //Test waardes aantal blokken per X.
        for(int i = 0; i < amountOfHazardsToSpawn; i ++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), 22.0f, 0.0f);   //Gen spawn pos van hazard
            Instantiate(hazards[hazardToSpawn], spawnPos, Quaternion.identity);     //Spawn hazard
        }
        yield return new WaitForSeconds(timeBetweenSpawns);
        canSpawn = true;
    }
}

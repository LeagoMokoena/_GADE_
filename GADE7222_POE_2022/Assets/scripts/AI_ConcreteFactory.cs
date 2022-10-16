using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_ConcreteFactory : AI_racerFactory
{
    public GameObject slowRacerPrefab;
    public GameObject normalRacerPrefab;
    public GameObject fastRacerPrefab;

    Racer spawnRacer(string racerType)
    {
        if (racerType.Equals("SlowRacer"))
        {
            Instantiate(slowRacerPrefab, new Vector3(58, 1, 396), Quaternion.identity);
            return null;
        }
        else
            return null;
    }
}

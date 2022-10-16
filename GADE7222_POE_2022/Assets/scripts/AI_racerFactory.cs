using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_racerFactory : MonoBehaviour
{
    public abstract class Racer
    {
        public Racer GetRacer(string racerType)
        {
            Racer racer;
            racer = spawnRacer(racerType);
            return racer;
        }
        public abstract Racer spawnRacer(string racerType);
    }
}

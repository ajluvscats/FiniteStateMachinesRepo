using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class GameEnvironement
{
  private static GameEnvironement instance;

  private List<GameObject> checkpoints = new List<GameObject>();
  
  private List<GameObject> Checkpoints { get {  return checkpoints; } }

    public static GameEnvironement Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new GameEnvironement();
                instance.Checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));

                instance.checkpoints = instance.checkpoints.OrderBy(waypoint => waypoint.name).ToList();
            }
            return instance;
        }
    }
   
}

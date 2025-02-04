using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnvironement
{
  private static GameEnvironement instance;
    private List<GameObject> checkpoints = new List<GameObject>();
   private List<GameObject> Chekpoints { get {  return checkpoints; } }

    public static GameEnvironement Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new GameEnvironement();
                instance.checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return instance;
        }
    }
   
}

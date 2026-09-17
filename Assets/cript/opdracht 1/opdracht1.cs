using System;
using UnityEngine;

public class opdracht1 : MonoBehaviour
{
    public string naam = "erwin";
    public int score = 423665;
    public bool alive = true;




    private void Start()
    {
        Debug.Log(naam + "has a score of " + score + "and is" + alive);
    }
}

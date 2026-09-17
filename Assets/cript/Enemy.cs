using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action enemydeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            enemydeath?.Invoke();
            gameObject.SetActive(false);
        }
            

    }
}

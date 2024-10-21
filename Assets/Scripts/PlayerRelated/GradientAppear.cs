using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GradientAppear : MonoBehaviour
{
    [SerializeField] public GameObject[] cosas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gradiente")) 
        { 
            foreach (GameObject cosa in cosas) 
            { 
                cosa.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Gradiente"))
        {
            foreach (GameObject cosa in cosas)
            {
                cosa.SetActive(false);
            }
        }
    }
}

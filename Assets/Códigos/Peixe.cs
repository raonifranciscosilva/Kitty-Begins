using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peixe : MonoBehaviour
{
    [SerializeField] private GameObject efeito;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(efeito, transform.position, Quaternion.identity);
            //StartCoroutine(PassaCena());
        }
    }
}

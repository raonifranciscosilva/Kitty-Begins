using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenasManager : MonoBehaviour
{
    [SerializeField] private float tempo;
    [SerializeField] private string cena;

    IEnumerator PassaCena()
    {
        yield return new WaitForSeconds(tempo);
        SceneManager.LoadScene(cena);
    }

    public void VaiCena(string cena)
    {   
        SceneManager.LoadScene(cena);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(PassaCena());
        }
    }
}

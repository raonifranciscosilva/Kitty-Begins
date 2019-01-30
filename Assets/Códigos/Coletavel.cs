using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coletavel : MonoBehaviour
{
    private int pontos = 0;
    [SerializeField] private Text textoPontos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textoPontos.text = pontos.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            pontos = pontos + 1;
            textoPontos.text = "Count: " + pontos.ToString();


        }


    }
}
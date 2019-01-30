using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despencar : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 posInicio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posInicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Caindo");
        rb.AddForce(Vector2.down, ForceMode2D.Impulse);
        StartCoroutine(EsperaTempo());
        rb.AddForce(new Vector2(-19.72f, 5.41f));

    }

    IEnumerator EsperaTempo()
    {
        yield return new WaitForSeconds(1.0f);
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    rb.AddForce(new Vector2(-19.72f, 5.41f));
    //}
}

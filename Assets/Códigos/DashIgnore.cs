using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Acrocatic;

public class DashIgnore : MonoBehaviour
{
    private Player player;
    private PlayerDash playerDash;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && player.dashing)
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            Debug.Log("Passando");
        }
    }

    void IgnoraColisao()
    {
        if (player.dashing)
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }


    // Update is called once per frame
    void Update()
    {
        IgnoraColisao();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnCollision : MonoBehaviour
{
    [SerializeField] private int life = 60;
    [SerializeField] private int damage = 10;


    public void DecreaseLife()
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Bullet"){
            life -= damage;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

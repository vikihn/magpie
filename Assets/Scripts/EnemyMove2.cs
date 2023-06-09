using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    public float speed;
    public bool MoveRight;

    // Update is called once per frame
    void Update()
    {
        if (!CatSleep2.sleep2)
        {
            if (MoveRight)
            {
                transform.Translate(2 * Time.deltaTime * speed, 0, 0);
                transform.localScale = new Vector2(0.13f, 0.13f);
            }

            else
            {
                transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
                transform.localScale = new Vector2(-0.13f, 0.13f);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn2"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }

            else
            {
                MoveRight = true;
            }
        }
    }
}

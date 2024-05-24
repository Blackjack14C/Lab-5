using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContacts : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<enemydamage>(out enemydamage enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
    }
}

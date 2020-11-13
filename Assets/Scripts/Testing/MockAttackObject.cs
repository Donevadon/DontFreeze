using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class MockAttackObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        other.collider.GetComponent<ITakingDamage>().TakeDamage(20f);
    }
}

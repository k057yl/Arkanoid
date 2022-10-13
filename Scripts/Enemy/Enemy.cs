using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EnemyData
{
    public class Enemy : MonoBehaviour
    {     
        public int hp;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            collision.gameObject.tag = "Player";
            hp--;
            if(hp <= 0)
            {
                Destroy(gameObject); 
            }
        }
    }
}

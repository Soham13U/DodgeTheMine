using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{ 
    
   public int damage = 1;
   public int speed = 5;
   public GameObject effect;
 


   private void Update(){
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
 
   void OnTriggerEnter2D(Collider2D other)
   {
       

       
        if(other.CompareTag("Player"))
        {   
           
            Instantiate(effect,transform.position,Quaternion.identity);
            other.GetComponent<Player>().health--;
            Destroy(gameObject);
        }
   }
}

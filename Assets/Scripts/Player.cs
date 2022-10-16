using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   private Vector2 tPos;
   public float yMove= 5;
   public float speed = 100;
   public float maxH;
   public float minH;
   public int health = 3;
   public GameObject effect;
   public Text hdisplay;
   public GameObject gg;

    // Update is called once per frame
  
    private void Update()
    {   
        hdisplay.text = health.ToString();
        if(health <=0 ){
            gg.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, tPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxH){
           
            Instantiate(effect,transform.position,Quaternion.identity);
            tPos = new Vector2(transform.position.x,transform.position.y + yMove);
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minH){
            
            Instantiate(effect,transform.position,Quaternion.identity);
            tPos = new Vector2(transform.position.x,transform.position.y - yMove);
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healt : MonoBehaviour
{
	
	//Max health and current health
    public float MaxHealth = 10f;
    public float Health;
	
	public Animator MyAnimator;
	
	public bool isAlive = true;
    
    //Check for being alive
    //public bool IsAlive = true;
	
    // Start is called before the first frame update
    void Start()
    {
        //Setting the health value
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {	
        if(Health <= 0 && isAlive==true){
            Die();
        }
    }
	
	void Die(){
        MyAnimator.SetTrigger("die");
		isAlive = false;
        //StartCoroutine(Dying());
    }
	
	void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "unicorn")
        {
			Debug.Log("Törmäys unicorniin");
			Health -= 3;
			Debug.Log(Health);
			
		}
	}
	
	
}

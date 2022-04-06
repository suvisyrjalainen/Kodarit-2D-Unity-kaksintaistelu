using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healt : MonoBehaviour
{
	
	//Max health and current health
    public float MaxHealth = 100f;
    public float Health;
    
    //Check for being alive
    public bool IsAlive = true;
	
    // Start is called before the first frame update
    void Start()
    {
        //Setting the health value
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {	
        if(Health <= 0){
            Die();
        }
    }
	
	void Die(){
        //Animator.SetTrigger("Die");
        //StartCoroutine(Dying());
    }
	
	
}

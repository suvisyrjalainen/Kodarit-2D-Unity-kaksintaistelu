using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath2 : MonoBehaviour
{
	public float maxHealth = 100f;
	public float Health = 0f;
	public Animator MyAnimator;
	
	
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		GameObject healthbar = GameObject.Find("HealthbarPlayer");
		
		Debug.Log("Mikä tämä on: " + healthbar);
        Health = maxHealth;
		GetComponent<slider>().SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Health == 0){
			Die();
			Health = -2;
		}
    }
	
	void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("TÃ¶rmasin Enemyyn");
			Health -= 2;
			Debug.Log(Health);
        }
    }
	
	void Die()
    {
        MyAnimator.SetTrigger("die");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
	
	public Animator MyAnimator;
	
	private int Chooser = 1;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if(Input.GetButtonDown("Fire1")){
			Punch();
		}
		
		if(Input.GetButtonDown("Fire2")){
			Kick();
		}
		
		if(Input.GetButtonDown("Fire3")){
			
		}
        
    }
	
	 //Playing one of two punch animations and calling the damage making function
    void Punch(){
        Chooser = Random.Range(0,2);
        if(Chooser == 1){
            MyAnimator.SetTrigger("left_punch");
        }
        else{
            MyAnimator.SetTrigger("right_punch");
        }
        
    }

    //Playing one of two kick animations and calling the damage making function
    void Kick(){
        Chooser = Random.Range(0,2);
        if(Chooser == 1){
            MyAnimator.SetTrigger("left_kick");
        }
        else{
            MyAnimator.SetTrigger("right_kick");
        }
        
    }
}

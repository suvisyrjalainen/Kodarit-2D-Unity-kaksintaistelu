using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
	public Slider omaslider;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    public void SetMaxHealth(float health)
    {
        omaslider.maxValue = health;
        omaslider.value = health;
		Debug.Log("Aetetaan maxValue");
    }
	
    public void SetHealth(float health)
    {
        omaslider.value = health;
    }
}

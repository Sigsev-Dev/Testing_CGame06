using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{	

    public class Restarter : MonoBehaviour
    {
    	Vector3 originalPos;
 
 	void Start()
  	{
      	originalPos = new Vector3(gameObject.transform.position.x, 					gameObject.transform.position.y, 						gameObject.transform.position.z);
 
  	}
    	
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                gameObject.transform.position = originalPos;
                Instantiate(gameObject);
            }
        }
    }
}



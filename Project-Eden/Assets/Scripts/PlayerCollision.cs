using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
	public float restartDelay = 2f;
	


	void OnCollisionEnter(Collision collisionInfo)
	{

		if (collisionInfo.collider.tag == "Enemy")
		{

			
	Restart();

		}
		if(collisionInfo.collider.tag == "Exit")
        {
			Debug.Log("You win");
        }
		void Restart()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

}

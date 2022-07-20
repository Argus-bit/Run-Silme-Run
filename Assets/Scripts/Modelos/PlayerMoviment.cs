using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
	public GUISkin skin;  //GUI skin for button styles
	public static bool RightWall; //static boolean variable indicates if MovingPlatform collided with box Collider on Right side of the screen
	public static bool LeftWall; //static boolean variable indicates if MovingPlatform collided with box Collider on Left side of the screen
	public static bool running = false; //static bool variable which indicates if ball is destroyed or not
	public bool BallCollidedMP = false;//Ball collided with Moving Platform

	void Update()
	{

		/*if (BallCollidedMP)
		{
			//if MovingPlatform collides with RightWall then it will start to move left in script #MovingPlatform
			if (MovingPlatform.RightWall)
			{
				//ball will move towards MovingPlatform to left
				Vector3 position = this.transform.position;
				position.x = position.x - 0.03f;
				this.transform.position = position;
			}
			//if MovingPlatform collides with LeftWall then it will start to move right
			if (MovingPlatform.LeftWall)
			{
				//ball will move towards MovingPlatform to right
				Vector3 position = this.transform.position;
				position.x = position.x + 0.03f;
				this.transform.position = position;
			}
		}*/
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		//ball is collided with MovingPlatform
		if (collider.tag == "MovingPlatform")
		{
			BallCollidedMP = true;
		}
	}

	void OnTriggerExit2D(Collider2D collider)
	{
		//ball is not collided with MovingPlatform
		if (collider.tag == "MovingPlatform")
		{
			BallCollidedMP = false;
		}
	}


	public void OnGUI()
	{
		GUI.skin = skin;

		if (PlayerMoviment.running)
		{
			//Button on the whole left side of the screen to move the ball to left
			if (GUI.RepeatButton(new Rect(Screen.width / 1.6f, Screen.height / 1.3f, Screen.width / 4, Screen.height / 6), "", skin.GetStyle("Right")))
			{
				running = true;
				Vector3 position = this.transform.position;
				position.x = position.x + 0.1f;
				this.transform.position = position;


			}

			//Button on the whole right side of the screen to move the ball to right
			if (GUI.RepeatButton(new Rect(Screen.width / 7.5f, Screen.height / 1.3f, Screen.width / 4, Screen.height / 6), "", skin.GetStyle("Left")))
			{
				running = true;
				Vector3 position = this.transform.position;
				position.x = position.x - 0.1f;
				this.transform.position = position;
			}
		}

	}
}

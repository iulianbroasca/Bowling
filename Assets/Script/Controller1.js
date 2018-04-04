#pragma strict

var cam : Transform;
var nextPos = 0.0;
var nextPos2 = -0.2;
var dampVelocity = 0.4;
var dampVelocity2 = 0.4;

function Update () 
{
 var newPos = Mathf.SmoothDamp(cam.transform.localPosition.x, nextPos, dampVelocity, .1);
 var newPos2 = Mathf.SmoothDamp(cam.transform.localPosition.y, nextPos2, dampVelocity, .1);
 
 cam.transform.localPosition.x = newPos;
 cam.transform.localPosition.y = newPos2;
 
			 if(Input.GetKey("d"))
 					{
 						nextPos = 2.5;
 						nextPos2 = 1.5;
 					}
			 else
					 {
					 nextPos = 0;
					 nextPos2 = 1.5;
					 }
 		 if(Input.GetKey("a"))
			 {
 					nextPos = -2.5;
 					nextPos2 = 1.5;
			 }
 		else
				 {
 				}
}
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    // User configurable
    public Camera Cam;
    public NavMeshAgent Agent;
    public ThirdPersonCharacter Character;

	// Use this for initialization
	void Start ()
	{
	    Agent.updateRotation = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Checks left mouse input
	    if (Input.GetMouseButtonDown(0))
	    {
            // takes mouse input position
	        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;

            // checks if hits any physics collider
	        if (Physics.Raycast(ray, out hit))
	        {
                // sets destination to the hit position
	            Agent.SetDestination(hit.point);
	        }
	    }

        // character movement
	    if (Agent.remainingDistance > Agent.stoppingDistance)
	    {
	        Character.Move(Agent.desiredVelocity, false, true);
	    }
	    else
	    {
	        Character.Move(Vector3.zero, false, false);
	    }
    }
}

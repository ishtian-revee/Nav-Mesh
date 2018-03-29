using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Player;    // A reffernce to the player's transform
    public Vector3 Offset;      // A variable to store offset position

    // Update is called once per frame
    void Update()
    {
        // Setting the camera position to behind the player forever
        transform.position = Player.position + Offset;

        // Setting the camera rotation to a little bit down side towards the player
        transform.rotation = Quaternion.Euler(40, 50, 0);
    }
}

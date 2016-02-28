using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

    public float speed;
    void FixedUpdate()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

    }
}

using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    [Header("Components")]
    public Rigidbody charRigidbody;

    [Header("Char Stats")]
    public float charSpeed;
    public float charJump;

    public enum charState
    {
        Normal,
        Mirror,
        AntiGrav,
        Async,
        Single
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetAxis("Horizontal") > 0)
        {
            charRigidbody.AddForce(charSpeed, 0, 0);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            charRigidbody.AddForce(-charSpeed, 0, 0);
        }

	}
}

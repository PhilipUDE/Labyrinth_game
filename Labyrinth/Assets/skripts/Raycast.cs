using UnityEngine;

public class Raycast : MonoBehaviour {

    private GameObject playerCamera;
    public RaycastHit hit;
    private Vector3 forward;


    void Start () {
        playerCamera = GameObject.Find("FirstPersonCharacter");
	}
	

	void Update ()
    {
        forward = playerCamera.transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(playerCamera.transform.position, forward, Color.green);
        Physics.Raycast(playerCamera.transform.position, forward, out hit);
    }
}

using UnityEngine;

public class Raycast : MonoBehaviour {

    [SerializeField]
    private bool debugInteraction = false;
    private Camera playerCamera;
    [SerializeField]
    private float interactableDistance = 4f;
    
    void Start () {
        playerCamera = Camera.main;
	}
	

	void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 forward = playerCamera.transform.TransformDirection(Vector3.forward);

        Debug.DrawRay(playerCamera.transform.position, forward, Color.green);

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, interactableDistance))
        {
            if (hit.transform.CompareTag("Interaction"))
            {
                if(debugInteraction)
                    Debug.Log("[Raycast] Hit Detected: " + hit.transform.gameObject+ " Press F to interact");

                
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.transform.GetComponent<Interaction>().Interact();
                }
            }
        }

       
    }
}

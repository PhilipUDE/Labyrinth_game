using UnityEngine;

public class Interaction : MonoBehaviour {

    private float interactableDistance = 4;
    private GameObject player;
    private GameObject timeGameObject;

    private RaycastHit hit;
    private Vector3 forward;

    private Vector3 positionInBed;

    void Start () {

        player = GameObject.Find("FPSController");
        timeGameObject = GameObject.Find("Time");
    }
	

	void Update () {

        forward = player.transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(player.transform.position, forward, Color.green);
        Physics.Raycast(player.transform.position, forward, out hit);


        if (hit.collider.gameObject == gameObject && hit.distance < interactableDistance)
        {
            Debug.Log("Press F to interact"); //Platzhalter für richtige Texteinblendung
            if (Input.GetKeyDown(KeyCode.F))
            {
                Interacting();
            }
        }
    }

    private void Interacting()
    {
        player.transform.position = transform.position;
        positionInBed = new Vector3(90, 0, 90);
        player.transform.Rotate(positionInBed);

        timeGameObject.GetComponent<DayNightCicle>().NewDay();
    }

}

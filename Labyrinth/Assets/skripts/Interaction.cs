using UnityEngine;

public class Interaction : MonoBehaviour {

    private float interactableDistance = 4;
    private GameObject player;
    private GameObject timeGameObject;

    private Vector3 positionInBed;

    void Start () {

        player = GameObject.Find("FPSController");
        timeGameObject = GameObject.Find("Time");
    }
	

	void Update ()
    {
        if (player.GetComponent<Raycast>().hit.collider.gameObject == gameObject && player.GetComponent<Raycast>().hit.distance < interactableDistance)
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

using UnityEngine;

public class DayNightCicle : MonoBehaviour {

    private GameObject Sun;
    private GameObject Moon;

	// Use this for initialization
	void Start () {
        Sun = GameObject.Find("Sun");
        Moon = GameObject.Find("Moon");
	}
	
	// Update is called once per frame
	void Update () {
        Sun.transform.RotateAround(Vector3.zero, Vector3.right, 0.5f*Time.deltaTime);
        Sun.transform.LookAt(Vector3.zero);
        Moon.transform.RotateAround(Vector3.zero, Vector3.right, 0.5f*Time.deltaTime);
        Moon.transform.LookAt(Vector3.zero);
    }
}

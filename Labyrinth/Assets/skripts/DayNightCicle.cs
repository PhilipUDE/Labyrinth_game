using UnityEngine;

public class DayNightCicle : MonoBehaviour {

    private GameObject Sun;
    private GameObject Moon;
    private float realTime = 0f;
    private float dayLength = 60f;
    public float gameTime;


    // Use this for initialization
    void Start ()
    {
        Sun = GameObject.Find("Sun");
        Moon = GameObject.Find("Moon");

        realTime = dayLength / 4; //Tag beginnt um 6 Uhr morgens

        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Clock();
        SunAndMoon();        
    }

    private void Clock()
    {
        realTime += Time.deltaTime;
        gameTime = (realTime / dayLength) * 24;
        Debug.Log(gameTime);

        if (gameTime >= 24)
        {
            realTime = 0;
            gameTime = 0;
        }
    }

    private void SunAndMoon()
    {
        Sun.transform.RotateAround(Vector3.zero, Vector3.right, (360 / dayLength) * Time.deltaTime);
        Sun.transform.LookAt(Vector3.zero);
        Moon.transform.RotateAround(Vector3.zero, Vector3.right, (360 / dayLength) * Time.deltaTime);
        Moon.transform.LookAt(Vector3.zero);
    }

    public void NewDay()
    {
        realTime = dayLength / 4f; //Tag beginnt um 6
        Sun.transform.position = new Vector3(0, 0, -500);
        Moon.transform.position = new Vector3(0, 0, 500);
    }
}

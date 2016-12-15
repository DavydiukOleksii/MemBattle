using UnityEngine;

public class GameControlleScr : MonoBehaviour {

    public GameObject memFriendPref;
    public GameObject memEnemyPref;
    public Transform gameField;

    // Use this for initialization
    void Start () {

        //add first mem
        GameObject tmpMem = Instantiate(memFriendPref);

        tmpMem.transform.SetParent(gameField);

        tmpMem.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        tmpMem.transform.localScale = new Vector3(1, 1, 1);

        tmpMem.GetComponent<OneMemScr>().armor = 2;
        tmpMem.GetComponent<OneMemScr>().attack = 5;
        tmpMem.GetComponent<OneMemScr>().health = 50;

        tmpMem.GetComponent<OneMemScr>().id = 0;

        //tmpMem.GetComponent<OneMemScr>().memImage = Resources.LoadAll(_imagePath, typeof(Texture2D));


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

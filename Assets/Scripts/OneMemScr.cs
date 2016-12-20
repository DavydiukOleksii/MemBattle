using UnityEngine;
using UnityEngine.UI;

public class OneMemScr : MonoBehaviour {

    public int id;
    public string memName;
    public int armor;
    public int health;
    public int attack;
    public int missChance;

    public static int chouseID = -1;

    public bool isEnemy = false;

    public Image memImage;

    void Start() {
        //transform.Find("OneMemPref").gameObject.GetComponent<Image>().sprite = memImage.sprite;
        transform.Find("StatsTable").gameObject.transform.Find("HealthText").gameObject.GetComponent<Text>().text = health.ToString();
        transform.Find("StatsTable").gameObject.transform.Find("AttackText").gameObject.GetComponent<Text>().text = attack.ToString();
        transform.Find("StatsTable").gameObject.transform.Find("ArmorText").gameObject.GetComponent<Text>().text = armor.ToString();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnMouseEnter()
    {
        if (!isEnemy && chouseID < 0) { 
            transform.Find("OneMemPref").gameObject.GetComponent<Outline>().effectColor = new Color(0, 0, 255);
        }

        if(isEnemy && chouseID > -1)
        {
            transform.Find("OneMemPref").gameObject.GetComponent<Outline>().effectColor = new Color(255, 0, 0);
        }
    }

    private void OnMouseExit()
    {
        if (chouseID < 0 || isEnemy)
        {
            transform.Find("OneMemPref").gameObject.GetComponent<Outline>().effectColor = new Color(0, 0, 0);
        }
    }

    private void OnMouseDown()
    {
        if (!isEnemy)
        {
            if (chouseID < 0)
            {
                transform.Find("OneMemPref").gameObject.GetComponent<Outline>().effectColor = new Color(0, 255, 0);
                //transform.Find("SkillsTable").gameObject.
                chouseID = id;
            }
            else
            {
                if (chouseID == this.id)
                {
                    transform.Find("OneMemPref").gameObject.GetComponent<Outline>().effectColor = new Color(0, 0, 255);
                    chouseID = -1;
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GUIManager m_cGUIManager;
    public GUIManager.eSceneStatus m_eSceneStatus;

    public GameObject Sun; //태양 이미지
    public GameObject Moon; //달 이미지

    static GameManager m_cInstance;

    public float DayTime = 0.0f;
    public float NightTime = 0.0f;
    public int DayNight = 0; //0이면 낮 1이면 밤


    static public GameManager GetInstance()
    {
        return m_cInstance;
    }
    // Use this for initialization
    void Start () {
        m_cInstance = this;
        m_cGUIManager.SetStatus(m_eSceneStatus);
        Sun.SetActive(true);

    }
    public void EventStart()
    {

        m_cGUIManager.SetStatus(GUIManager.eSceneStatus.PLAY);
    }
    // Update is called once per framex
    void Update () {
        if (DayNight == 0)
        {
            DayTime += Time.deltaTime;
            if (DayTime >= 5.0f)
            {
                Sun.SetActive(false);
                Moon.SetActive(true);

                DayNight = 1;
                DayTime = 0.0f;
            }

        }

        else if (DayNight == 1)
        {
            NightTime += Time.deltaTime;
            if(NightTime>=5.0f)
            {
            
                Sun.SetActive(true);
                Moon.SetActive(false);
                DayNight = 0;
                NightTime = 0.0f;
            }
        }


	}
}

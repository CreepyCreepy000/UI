using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GUIManager : MonoBehaviour {
    public List<GameObject> m_listScene;
    public int Selection = 0;

    public GameObject MenuPanel;
    public GameObject ShopPanel;
    public GameObject FurnitureScroll;
    public GameObject WallScroll;

    public Image GhostImage1;
    public Image GhostImage2;
    public Image GhostImage3;

    public int GhostRandom1;
    public int GhostRandom2;
    public int GhostRandom3;

    public enum eSceneStatus {TITLE,PLAY,GHOST,OPTION,MAX };
    eSceneStatus m_eCurrentStatus;//현재상태


    public void SetStatus(eSceneStatus status)
    {
        switch (status)
        {
            case eSceneStatus.TITLE:
                break;
            case eSceneStatus.PLAY:
                break;

            case eSceneStatus.GHOST:
                break;

            case eSceneStatus.OPTION:
                break;
        }
        ShowScene(status);
        m_eCurrentStatus = status;
    }
    public void UpdateStatus()
    {
        switch (m_eCurrentStatus)
        {
            case eSceneStatus.TITLE:
                Time.timeScale = 0f;
                break;
            case eSceneStatus.PLAY:
                
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    MenuPanel.SetActive(false);
                    ShopPanel.SetActive(false);
                    FurnitureScroll.SetActive(false);
                    WallScroll.SetActive(false);
                }
                break;

            case eSceneStatus.GHOST:
                Time.timeScale = 0f;
                
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    SetStatus(GUIManager.eSceneStatus.PLAY);
                    Selection = 0;
                    Time.timeScale = 1f;
                }
                break;

            case eSceneStatus.OPTION:
                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    SetStatus(GUIManager.eSceneStatus.PLAY);
                    Selection = 0;
                }
                break;
        }
    }

    public GameObject GetScene(eSceneStatus status)
    {
        return m_listScene[(int)status];
    }

    public void ShowScene(eSceneStatus status)
    {
        for (eSceneStatus e = 0; e < eSceneStatus.MAX; e++)
        {
            if (status == e)
                m_listScene[(int)e].SetActive(true);
            else
                m_listScene[(int)e].SetActive(false);
        }
    }
    public void MenuOpen()
    {
        MenuPanel.SetActive(true);
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        SetStatus(GUIManager.eSceneStatus.PLAY);
    }

    public void GhostButton()
    {
        SetStatus(GUIManager.eSceneStatus.GHOST);
        GhostRandom1 = Random.Range(0, 100);
        GhostRandom2 = Random.Range(0, 100);
        GhostRandom3 = Random.Range(0, 100);

        if (GhostRandom1 < 20)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost1");
        }
        else if (GhostRandom1 >=20 && GhostRandom1 < 40)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost2");
        }
        else if (GhostRandom1 >=40 && GhostRandom1 < 50)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost3");
        }
        else if (GhostRandom1 >= 50 && GhostRandom1 < 60)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost4");
        }
        else if (GhostRandom1 >= 60 && GhostRandom1 < 70)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost5");
        }
        else if (GhostRandom1 >= 70 && GhostRandom1 < 80)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost6");
        }
        else if (GhostRandom1 >= 80 && GhostRandom1 < 90)
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost7");
        }
        else
        {
            GhostImage1.sprite = Resources.Load<Sprite>("Monster/Ghost8");
        }




        if (GhostRandom2 < 20)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost1");
        }
        else if (GhostRandom2 >= 20 && GhostRandom2 < 40)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost2");
        }
        else if (GhostRandom2 >= 40 && GhostRandom2 < 50)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost3");
        }
        else if (GhostRandom2 >= 50 && GhostRandom2 < 60)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost4");
        }
        else if (GhostRandom2 >= 60 && GhostRandom2 < 70)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost5");
        }
        else if (GhostRandom2 >= 70 && GhostRandom2 < 80)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost6");
        }
        else if (GhostRandom2 >= 80 && GhostRandom2 < 90)
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost7");
        }
        else
        {
            GhostImage2.sprite = Resources.Load<Sprite>("Monster/Ghost8");
        }




        if (GhostRandom3 < 20)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost1");
        }
        else if (GhostRandom3 >= 20 && GhostRandom3 < 40)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost2");
        }
        else if (GhostRandom3 >= 4 && GhostRandom3 < 50)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost3");
        }
        else if (GhostRandom3 >= 50 && GhostRandom3 < 60)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost4");
        }
        else if (GhostRandom3 >= 60 && GhostRandom3 < 70)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost5");
        }
        else if (GhostRandom3 >= 70 && GhostRandom3 < 80)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost6");
        }
        else if (GhostRandom3 >= 80 && GhostRandom3 < 90)
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost7");
        }
        else
        {
            GhostImage3.sprite = Resources.Load<Sprite>("Monster/Ghost8");
        }

    }

    public void ShopButton()
    {
        ShopPanel.SetActive(true);
    }

    public void FurnitureButton()
    {
        FurnitureScroll.SetActive(true);
        MenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
    }

    public void WallButton()
    {
        WallScroll.SetActive(true);
        MenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
    }

    void Start () {
		
	}
    
	
	// Update is called once per frame
	void Update () {
        UpdateStatus();
    }
}

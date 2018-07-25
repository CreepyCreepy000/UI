using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIPanel : MonoBehaviour {
    public Image m_cImage;
    public Text m_cText;

    public void SetFurniture(ItemManager.eFurniture furniture)
    {
        Furniture cFurniture = GameManager.GetInstance().m_cItemManager.GetFurniture(furniture);
        m_cImage.sprite = Resources.Load<Sprite>("Furniture/" + cFurniture.Img);
        GameManager.GetInstance().m_cItemManager.FSelection = (int)furniture;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 40, 100, 20), "GUIPanel"))
        {
            SetFurniture(ItemManager.eFurniture.Bed);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

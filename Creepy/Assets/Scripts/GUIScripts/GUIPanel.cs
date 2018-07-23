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
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture_Button : MonoBehaviour {

    public ItemManager.eFurniture furniture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FurnitureSelect()
    {
        GameManager.GetInstance().FurnitureSelect = GameManager.GetInstance().m_cItemManager.GetFurniture(furniture).Selection;
    }


}

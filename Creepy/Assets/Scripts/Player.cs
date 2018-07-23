using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    List<ItemManager.eFurniture> m_listFurnitureInven = new List<ItemManager.eFurniture>();
    ItemManager.eFurniture furniture;
    public int Fselect;//가구선택
    public int Gselect;//유령선택
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetFurnitureInven(ItemManager.eFurniture furniture)
    {
        m_listFurnitureInven.Add(furniture);
    }

    public ItemManager.eFurniture GetFurnitureInven(ItemManager.eFurniture furniture)
    {
        return m_listFurnitureInven.Find(obj => obj.Equals(furniture));
    }

    public ItemManager.eFurniture GetFurnitureInven(int idx)
    {
        return m_listFurnitureInven[idx];
    }

    public void DeleteFurnitureInven(ItemManager.eFurniture furniture)
    {
        m_listFurnitureInven.Remove(furniture);
    }

    public int GetFurnitureInvenSize()
    {
        return m_listFurnitureInven.Count;
    }
}

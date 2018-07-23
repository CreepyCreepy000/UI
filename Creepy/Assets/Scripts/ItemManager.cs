using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture
{
    string strName;
    string strImg;
    int nSelection;

    public string Name { get { return strName; } }
    public string Img { get { return strImg; } }
    public int Selection { get { return nSelection; } }

    public Furniture(string name, string img, int selection)
    {
        Set(name, img, selection);
    }

    public void Set(string name, string img, int selection)
    {
        strName = name;
        strImg = img;
        nSelection = selection;
    }


}

public class ItemManager : MonoBehaviour {
    public enum eFurniture { NONE=-1, Bed, Bookshelf, Clock, Piano, Shelf,Sofa, Tree}
    public List<Furniture> m_listFurniture = new List<Furniture>();
	// Use this for initialization
	void Start () {
        FurnitureInitialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FurnitureInitialize()
    {
        m_listFurniture.Add(new Furniture("침대", "Bed", 1));
        m_listFurniture.Add(new Furniture("책장", "Bookshelf", 2));
        m_listFurniture.Add(new Furniture("시계", "Clock", 3));
        m_listFurniture.Add(new Furniture("피아노","Piano", 4));
        m_listFurniture.Add(new Furniture("선반", "Shelf", 5));
        m_listFurniture.Add(new Furniture("소파", "Sofa", 6));
        m_listFurniture.Add(new Furniture("나무","Tree", 7));
    }

    public Furniture GetFurniture(eFurniture furniture)
    {
        return m_listFurniture[(int)furniture];
    }



}

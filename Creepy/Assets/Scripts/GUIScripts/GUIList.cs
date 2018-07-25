using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIList : MonoBehaviour {
    List<GameObject> m_listList = new List<GameObject>();
    public GameObject m_prefabButton;
    public GameObject m_objContext;

    public void AddFurniture(ItemManager.eFurniture furniture, GUIPanel cPanel)
    {
        Furniture cFurniture = GameManager.GetInstance().m_cItemManager.GetFurniture(furniture);
        GameObject objButton = Instantiate(m_prefabButton);
        GUIFurnitureButton cFButton = objButton.GetComponent<GUIFurnitureButton>();
        Button btnButton = objButton.GetComponent<Button>();
        btnButton.onClick.AddListener(() => cPanel.SetFurniture(furniture));
        cFButton.m_cText.text = cFurniture.Name;
        objButton.transform.SetParent(m_objContext.transform);
        m_listList.Add(objButton);

    }

    public void DeleteItem(int idx)
    {
        GameObject button = m_listList[idx];
        m_listList.Remove(m_listList[idx]);
        Destroy(button);
    }

    public void ReleaseItem(int idx)
    {
        for (int i = m_listList.Count - 1; i >= 0; i--)
            DeleteItem(i);
        m_listList.Clear();

    }
    public void SetContextSize()
    {
        RectTransform rectContext = m_objContext.GetComponent<RectTransform>();
        GridLayoutGroup grid = m_objContext.GetComponent<GridLayoutGroup>();
        int nSize = m_listList.Count;
        int nContextHeight = (int)(grid.cellSize.y * nSize);
        rectContext.sizeDelta = new Vector2(rectContext.sizeDelta.x, nContextHeight);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

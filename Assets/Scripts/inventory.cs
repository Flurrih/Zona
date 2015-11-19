using UnityEngine;
using System.Collections;

public class inventory : MonoBehaviour {
    private int numberSlots;
    private item[] inventoryArray;

	// Use this for initialization
	void Start () {
        inventoryArray = new item[numberSlots];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addItem(int item_id)
    {
        inventoryArray[item_id - 1].own();
    }

    public void useItem(int item_id)
    {
        inventoryArray[item_id - 1].use();
    }
}

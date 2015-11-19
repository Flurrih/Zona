using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
    public int id;
    public int quantity;
    public string itemName;
    public string description;
    private bool isUsed;
    private bool owned;
	// Use this for initialization
	void Start () {
        isUsed = false;
        owned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void own()
    {
        owned = true;
    }

    public void use()
    {
        if(quantity > 0)
        {
            isUsed = true;
            quantity--;
            //do something
        }
        
    }
}

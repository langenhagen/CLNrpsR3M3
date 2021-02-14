using UnityEngine;
using System.Collections;

public class OnOff : MonoBehaviour {

    public bool OffAllObjectsOnActivation = false;

    public GameObject Item1;
    public KeyCode    Item1Key;

    public GameObject Item2;
    public KeyCode    Item2Key;

    public GameObject Item3;
    public KeyCode    Item3Key;

    public GameObject Item4;
    public KeyCode    Item4Key;
    
    public GameObject Item5;
    public KeyCode    Item5Key;

    public GameObject Item6;
    public KeyCode    Item6Key;

    public GameObject Item7;
    public KeyCode    Item7Key;

    public GameObject Item8;
    public KeyCode    Item8Key;

    public GameObject Item9;
    public KeyCode    Item9Key;

    //##################################################################################################
    // METHODS
	
	// Update is called once per frame
	void Update () {

        ToggleActive(Item1, Item1Key);
        ToggleActive(Item2, Item2Key);
        ToggleActive(Item3, Item3Key);
        ToggleActive(Item4, Item4Key);
        ToggleActive(Item5, Item5Key);
        ToggleActive(Item6, Item6Key);
        ToggleActive(Item7, Item7Key);
        ToggleActive(Item8, Item8Key);
        ToggleActive(Item9, Item9Key);
	}

    //##################################################################################################
    // HELPERS

    private void ToggleActive(GameObject item, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode) && item != null)
        {
            bool newActive = !item.activeSelf;


            if (newActive && OffAllObjectsOnActivation)
            {
                // shut down all objects
                if (Item1 != null) Item1.SetActive(false);
                if (Item2 != null) Item2.SetActive(false);
                if (Item3 != null) Item3.SetActive(false);
                if (Item4 != null) Item4.SetActive(false);
                if (Item5 != null) Item5.SetActive(false);
                if (Item6 != null) Item6.SetActive(false);
                if (Item7 != null) Item7.SetActive(false);
                if (Item8 != null) Item8.SetActive(false);
                if (Item9 != null) Item9.SetActive(false);
            }



            item.SetActive( newActive);

        }
    }
}

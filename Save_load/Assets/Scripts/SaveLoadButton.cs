using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadButton : MonoBehaviour {

	public void save()
    {
        GameController.control.SaveGame();
    }

    public void load()
    {
        GameController.control.LoadGame();
    }
}

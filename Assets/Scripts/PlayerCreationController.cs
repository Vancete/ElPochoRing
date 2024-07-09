using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreationController : MonoBehaviour
{
    public PlayerModelController playerModelController;
    public Text classText;
    public String[] classTypes;
    public int selectedClass = 0;

    public void ChangeClass(int diff)
    {
        selectedClass = selectedClass + diff >= classTypes.Length ? 0 : selectedClass + diff < 0 ? classTypes.Length : selectedClass + diff;
        classText.text = classTypes[selectedClass];
        playerModelController.LoadClass(selectedClass);
    }

}

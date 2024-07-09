using UnityEngine;

public class PlayerModelController : MonoBehaviour
{
    public GameObject[] maleHeads;
    public GameObject[] femaleHeads;
    public GameObject[] maleBodyBase;
    public GameObject[] femaleBodyBase;

    void HideAll(GameObject[] gameObjects)
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
    }

    void ShowAll(GameObject[] gameObjects)
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(true);
        }
    }

    public void LoadClass(int selectedClass)
    {
        HideAll(maleHeads);
        HideAll(femaleHeads);
        HideAll(maleBodyBase);
        HideAll(femaleBodyBase);
        switch (selectedClass)
        {
            case 0:
                maleHeads[0].SetActive(true);
                ShowAll(maleBodyBase);
                break;

            case 1:
                femaleHeads[0].SetActive(true);
                ShowAll(femaleBodyBase);
                break;

            case 2:
                femaleHeads[0].SetActive(true);
                ShowAll(maleBodyBase);
                break;
        }
    }

}

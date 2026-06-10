using UnityEngine;

public class ToggleTutorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject tut;
    public void toggleTutorialScreen()
    {
        if (tut != null)
        {
            tut.SetActive(!tut.activeSelf);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

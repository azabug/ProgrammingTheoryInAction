using UnityEngine;
using UnityEngine.UI;

public class RedPillar : Pillar
{
    public string pillarName;
    public Color pillarColor = Color.red;
    public Button pButton;

    //UnityEvent m_MyEvent = new UnityEvent();
    private void Start()
    {
        pButton = GameObject.Find("pBut").GetComponent<Button>();
        pButton.onClick.AddListener(DisplayName);

    }
    public void DisplayName()
    {
        Debug.Log(pillarName + " " + objectType);
    }
}
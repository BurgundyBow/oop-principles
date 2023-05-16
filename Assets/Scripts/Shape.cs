using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] protected TMP_Text displayText;
    [SerializeField] private string shapeName;
    public virtual void DisplayText()
    {
        Debug.Log("clicked");
        displayText.text = "you have clicked on " + shapeName;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}

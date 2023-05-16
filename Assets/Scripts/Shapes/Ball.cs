using UnityEngine;
public class Ball : Shape
{
    private float r, g, b;
    public override void DisplayText()
    {
        base.DisplayText();
        r = Random.Range(0.0f, 1.0f);
        g = Random.Range(0.0f, 1.0f);
        b = Random.Range(0.0f, 1.0f);
        displayText.color = new Color(r, g, b);
    }
}


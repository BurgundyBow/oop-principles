using UnityEngine;
public class Cuboid : Shape
// INHERITANCE ^
{
    private float zAngle;
    public override void DisplayText()
    {
        base.DisplayText();
        zAngle = Random.Range(0.0f, 360.0f);
        displayText.transform.Rotate(0, 0, zAngle);
        // POLYMORPHISM ^
    }
}
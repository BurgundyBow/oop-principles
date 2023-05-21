using UnityEngine;
public class Capsule : Shape // INHERITANCE
{
    private float xAngle, yAngle, zAngle;
    public override void DisplayText() // POLYMORPHISM 
    {
        base.DisplayText();
        xAngle = Random.Range(0.0f, 360.0f);
        yAngle = Random.Range(0.0f, 360.0f);
        zAngle = Random.Range(0.0f, 360.0f);
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
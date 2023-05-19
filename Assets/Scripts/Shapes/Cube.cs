using UnityEngine;
public class Cube : Shape
{
    private float scale;
    [SerializeField] HealthSystem healthSystem;
    public override void DisplayText()
    {
        base.DisplayText();
        scale = Random.Range(0.0f, 3.0f);
        displayText.transform.localScale = new Vector3(scale, scale, scale);

        if (healthSystem.Health > 5)
        {
            healthSystem.TakeDamage(5);
        }
       // make this random scale
   
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private float _health;
    [SerializeField] private float healthReadCounter;

    //ENCAPSULATION
    public float Health
    {
        get
        {
            healthReadCounter++;
            return _health;
        }
        private set
        {
            _health = Mathf.Clamp(value, 0, 10);
            slider.value = _health;
        }
    }

    //ABSTRACTION
    public void TakeDamage(float _amount = 1)
    {
        Health = Health - _amount;
    }

    public void Heal(float _amount = 1)
    {
        Health = Health + _amount;
    }
}

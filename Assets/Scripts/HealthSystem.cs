using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private Slider slider;

    [SerializeField] private float healthReadCounter;

    //ENCAPSULATION
    private float _health;

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

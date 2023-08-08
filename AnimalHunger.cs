using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private int amountToBeFed;
    private UIManager UI_Manager;

    void Start()
    {
        UI_Manager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    public void Slider()
    {
        hungerSlider.value++;

        if (hungerSlider.value==amountToBeFed)
        {
            UI_Manager.Score();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            Slider();
        }
    }
}

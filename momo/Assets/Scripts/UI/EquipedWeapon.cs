using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipedWeapon : MonoBehaviour
{
    [SerializeField] public Sprite bowImage;
    [SerializeField] public Sprite daggerImage;
    [SerializeField] public Sprite swordImage;
    [SerializeField] public Sprite batImage;
    Image image;
    TextMeshProUGUI weaponTitle;

    private void Start()
    {
        image = GetComponent<Image>();
        GameObject title = transform.Find("Title").gameObject;
        weaponTitle = title.GetComponent<TextMeshProUGUI>();
    }

    public void equipWeapon(string weaponName)
    {
        if (weaponName == "bow")
        {
            image.sprite = bowImage;
            weaponTitle.text = weaponName;
        }

        else if (weaponName == "dagger")
        {
            image.sprite = daggerImage;
            weaponTitle.text = weaponName;
        }

        else if (weaponName == "sword")
        {
            image.sprite = swordImage;
            weaponTitle.text = weaponName;
        }

        else if (weaponName == "bat")
        {
            image.sprite = batImage;
            weaponTitle.text = weaponName;
        }

        else
        {
            Debug.Log("No such weapon " + weaponName);
        }
    }

    public void SetColorWhite()
    {
        image.color = Color.white;
    }
}

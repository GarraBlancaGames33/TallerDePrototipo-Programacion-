using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmunitionManager : MonoBehaviour
{
    public static AmmunitionManager instance;

    [SerializeField] private int ammunitionCount;
    [SerializeField] private Text ammunitionCountText;

    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    public void AddAmmunition(int value)
    {
        ammunitionCount += value;
        UpdatedAmmoCountUI();
    }

    public bool ConsumeAmmo()
    {
        if (ammunitionCount > 0)
        {
            ammunitionCount--;
            UpdatedAmmoCountUI();
            return true;
        }
        else
        {
            return false;
        }
    }

    private void UpdatedAmmoCountUI()
    {
        ammunitionCountText.text = "Ammo: " + ammunitionCount;
    }
}

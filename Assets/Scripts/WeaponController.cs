using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GunWeapon myWeapon;
    GunWeapon lastWeapon;

    public Transform tip;
    public TextMesh sound;
    // public UnityEngine.UI.Text info;

    void Start()
    {
        lastWeapon = myWeapon;
        myWeapon.InitSetting();
    }

    void Update()
    {
        if (lastWeapon != myWeapon)
        {
            lastWeapon = myWeapon;
            myWeapon.InitSetting();
        }

        myWeapon.Using(tip, sound, this.transform);

        if (myWeapon.data.maxBullet == 0)
        {
            myWeapon = GetComponent<DefaultGun>();
        }
    }
}
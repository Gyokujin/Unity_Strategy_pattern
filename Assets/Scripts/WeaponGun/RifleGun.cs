using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleGun : GunWeapon
{
    public override void InitSetting()
    {
        data.delayTime = 0.5f;
        data.info = "ÇöÀç ¹«±â : µ¹°Ý ±ÇÃÑ";
        data.soundEffect = "ÅÁ!";
        data.maxBullet = 20;
        data.bullet = Resources.Load<GameObject>("DefaultBullet");
    }

    public override void Using(Transform tip, TextMesh sound, Transform player)
    {
        base.Using(tip, sound, player);
        player.transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * 10 * Time.deltaTime;
    }
}